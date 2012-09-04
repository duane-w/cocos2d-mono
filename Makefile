MACCORE_DIR = ../MonoMac/monomac/src
COCOS2D_DIR = ../cocos2d-iphone/cocos2d/

all: bindgen.exe Cocos2d.cs Cocos2d.dll

bindgen.exe: Generator.cs Options.cs
	gmcs -g -out:bindgen.exe Generator.cs Options.cs -define:MONOMAC -r:$(MACCORE_DIR)/MonoMac.dll

Cocos2d.cs: bindgen.exe ruleslist.txt
	mono bindgen.exe -rules ruleslist.txt $(COCOS2D_DIR)/*.h $(COCOS2D_DIR)/Platforms/iOS/*.h $(COCOS2D_DIR)/Platforms/Mac/*.h $(COCOS2D_DIR)/Support/CCArray.h > Cocos2d.cs

Cocos2d.dll: bindgen.exe Cocos2d.cs Extras.cs Helper.cs
	cp $(MACCORE_DIR)/MonoMac.dll .; mono $(MACCORE_DIR)/bmac.exe Cocos2d.cs -s=Extras.cs -x=Helper.cs -d=MONOMAC -r:System.Drawing.dll; rm MonoMac.dll

clean:
	rm bindgen.exe Cocos2d.cs Cocos2d.dll
