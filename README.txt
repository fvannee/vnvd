This repository contains the source code for the compiler for the VNVD programming language. Stas Verberkt and Floris van Nee developed this fully object-oriented language for the course Compiler Construction. The reader is encouraged to take a look at the examples directory to see the power of our language in practice, or to look at the Vnvd directory for the compiler source code.
The source code is archived here to serve as a reminder for all the hard work that was put into this project.

--------------------------------------------------------------------------------------

Goedendag lezer,

Welkom op de Vertalerbouw CD-ROM van Floris van Nee en Stas Verberkt.
Op deze CD-ROM zijn een aantal bestanden en directories te vinden.
De indeling hiervan is als volgt:

 * documentation/	Dit bevat alle gegenereerde documentatie van de code van de VNVD compiler.
			Het beginpunt voor deze documentatie is "documentation/html/index.html".
 * examples/		Deze map bevat een breed arsenaal aan testprogramma's.
			Deze programma's zijn ook allemaal in het bijgeleverde verslag beschreven.
 * verslag/		Deze map bevat het verslag op PDF formaat.
 * Vnvd/		Deze map bevat de broncode van de VNVD compiler.
			Alle door ANTLR gegenereerde code bevindt zich in "Vnvd/Antlr/".
			Daarnaast is het bestand "Vnvd.sln" het Visual Studio project.
			Compilatie instructies en vereisten staan ook in het verslag.

Voor het in elkaar zetten van de compiler zijn een aantal handige batch files meegeleverd.
Eerst dient men af te dalen naar "Vnvd/Antlr/" waar het script "compile.bat" gedraaid wordt.
Vervolgens gaat men naar de map "Vnvd/bin" waar wederom het script "compile.bat" gedraaid wordt.
Voor dit alles is wel het .NET Framework SDK vereist.

Met de Mono SDK is het overigens ook mogelijk, daarvoor zijn er ook scripts meegeleverd.
Dit zijn de Bash scripts genaamd "compile.sh".
Deze kunnen op dezelfde wijze gebruikt worden als de Windows varianten.

Na de compilatie stappen is de VNVD compiler te vinden als "Vnvd/bin/Vnvd.exe".
Op die locatie heeft hij ook al z'n includes.
De gebruiksaanwijzing van de compiler zelf valt ook in het verslag te vinden.

Bedankt voor uw tijd,

Floris van Nee en Stas Verberkt

