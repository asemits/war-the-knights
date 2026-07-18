1. Installed uwdtool:
pip install uwdtool --break-system-packages
2. Used uwdtool to extract global-metadata.dat:
uwdtool -u -i war-the-knights.data -o ./a
Note: extracted folder can be named anything, obviously
3. Get rid of everything else except global-metadata.dat
mv a/Il2CppData/Metadata/global-metadata.dat ./ && rm -r a
4. Use Il2CppDumper
./Il2CppDumper war-the-knights.wasm global-metadata.dat output/
