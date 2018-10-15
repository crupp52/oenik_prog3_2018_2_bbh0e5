# OENIK_PROG3_2018_2_BBH0E5

Zuck Levente - BBH0E5

# Specifikáció

## Feladat leírás

Egy újonnan induló videómegosztó oldalnak kell elkészíteni az adatbázisát. Fontos a videókat feltöltő felhasználók összekapcsolása a saját tartalmukkal, illetve a videófeltöltések pontos monitorozhatóság. A felhasználókat, a videókat, a kategóriákat és feltöltések eseményét egyedi azonosítóval látjuk el a könnyű azonosítás érdekében.

## Táblák

Videos tábla: Videók alapvető adatainak (cím, kategóriája, feltöltő azonosítója, kedvelések száma, hozzászólások száma) tárolása ebben a táblában történik. A videót a saját azonosítójával azonosítjuk, mert több videónak is lehet azonos a címe, illetve könnyebb lesz a hivatkozás a későbbiekben.

Creators tábla: A készítők azonosítója, neve, születési dátuma email címe és prémium tagsága kerül tárolásra a táblában. 

Categories tábla: A videókhoz adható kategóriák azonosítója, neve és felnőtt tartalmat jelölő változója is ebben a táblában kap majd helyet.

Feltöltés tábla: Ez a tábla teremt kapcsolatot a felhasználók és a feltöltendő videók között. Minden egyes feltöltéshez tartozik egy azonosító, a videó azonosítója, a felhasználó azonosítója és a feltöltés dátuma.
