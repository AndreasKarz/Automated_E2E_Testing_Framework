#language: de-DE
@base @search
Funktionalität: Suchservice auf der Homepage
	Um 
		Informationen zu verschiedenen Versicherungsthemen zu erhalten
	Als 
		Kunde benutze ich die Suche
	Ich
		finde die gewünschten Informationen


Grundlage: Ich befinde mich auf der Homepage
	Angenommen Die Homepage ist geöffnet
		Und Die Sprache ist auf 'DE' gestellt

Szenariogrundriss: Die Suche nach Vorsorge liefert die gewünschten Informationen
	Wenn Ich nach dem Begriff '<Suchbegriff>' suche 
	Dann Werden mindestens <Anzahl> Resultate gefunden
Beispiele: 
	| Suchbegriff              | Anzahl |
	| Vorsorge                 | 400    |
	| Invest                   | 80     |
	| 3a                       | 100    |

Szenario: Suche ohne Resultate
	Wenn Ich nach dem Begriff 'EinBegriffDenEsNichtGibt' suche 
	Dann Wird die Meldung 'Suche liefert kein Ergebnis' angezeigt
