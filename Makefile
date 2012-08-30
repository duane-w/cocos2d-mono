MACCORE_DIR = ../MonoMac/monomac/src
COCOS2D_DIRR = ../cocos2d-iphone/cocos2d/
COCOS2D_DIR = /Users/duane/Source/Cocos2d/cocos2d-iphone/cocos2d

all: bindgen.exe Cocos2d.cs Cocos2d.dll

bindgen.exe: Generator.cs Options.cs
	gmcs -g -out:bindgen.exe Generator.cs Options.cs -define:MONOMAC -r:$(MACCORE_DIR)/MonoMac.dll

Cocos2d.cs: bindgen.exe
	mono bindgen.exe $(COCOS2D_DIR)/*.h $(COCOS2D_DIR)/Platforms/iOS/*.h $(COCOS2D_DIR)/Platforms/Mac/*.h $(COCOS2D_DIR)/Support/CCArray.h > Cocos2d.cs

Cocos2d.dll: bindgen.exe Cocos2d.cs
	cp $(MACCORE_DIR)/MonoMac.dll .; mono $(MACCORE_DIR)/bmac.exe Cocos2D.cs Extras.cs -d=MONOMAC -r:System.Drawing.dll; rm MonoMac.dll
