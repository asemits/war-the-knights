1. Cloned Cpp2IL repository:
git clone https://github.com/SamboyCoding/Cpp2IL
2. cd'd into repository
cd Cpp2IL
3. Builded with .NET 10
dotnet build Cpp2IL/Cpp2IL.csproj -c Release
4. Copied result 
mkdir asdf 
cp -r Cpp2IL/bin/Release/net10.0/Cpp2IL/ asdf/
rm -r Cpp2IL/
5. Ran Cpp2IL
cd ..
./Cpp2IL/Cpp2IL --game-path="build/" --force-binary-path="build/war-the-knights.wasm" --force-metadata-path="build/global-metadata.dat" --wasm-framework-file="build/war-the-knights.framework.js" --force-unity-version="6000.3.19" --output-as dummydll

Note: I had to build it because this repository can't keep up with its releases. I haven't a clue why it doesn't, but you will have to build it yourself on Windows. I'm not building it for you
Note 2: build/ directory contains global-metadata.dat, war-the-knights.data, war-the-knights.framework.js and war-the-knights.wasm
