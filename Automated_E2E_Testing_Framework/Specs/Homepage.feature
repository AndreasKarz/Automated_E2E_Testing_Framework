@base
Feature: Homepage base functionalities
	In order to 
		avoid silly mistakes
	As a 
		math idiot
	I want to 
		be told the sum of two numbers

Background: Open the Homepage
	Given I open the Homepage

@language @quarter
Scenario Outline: Check the language navigation
	When I change the language to '<lang>'
	Then the disclaimer should be shown
		And the <title>, the <text> and the <linktext> should be correct
	Examples: 
	| lang | title                    | text                                                                                                                                                                                                                                                                                                 | linktext                                         |
	| DE   | Informationen zu Cookies | Swiss Life möchte Ihnen stets den bestmöglichen Service bieten. Damit Sie unsere Website optimal nutzen und wir diese fortlaufend verbessern können, verwenden wir Cookies. Durch die weitere Nutzung der Website stimmen Sie der Verwendung von Cookies zu.                                         | Weitere Informationen zum Datenschutz            |
	| EN   |                          | Swiss Life strives to always offer the best-possible service. We use cookies on our website to enhance your experience and make ongoing improvements. By continuing to browse the site, you are agreeing to our use of cookies.                                                                      | Privacy policy                                   |
	| FR   |                          | Swiss Life tient à vous offrir le meilleur service possible en tout temps. Afin que vous puissiez faire un usage optimal de notre site Web et que nous puissions continuellement l’améliorer, nous utilisons des cookies. En continuant à utiliser le site Web, vous consentez à l’usage de cookies. | Déclaration relative à la protection des données |
	| IT   |                          | Swiss Life desidera offrirle sempre il servizio migliore in assoluto. Ci avvaliamo di cookie per garantirle un’esperienza ottimale del nostro sito web e per migliorarlo costantemente. Continuando a utilizzare il nostro sito web, lei esprime il suo consenso all’uso dei cookie.                 | Dichiarazione sulla protezione dei dati          |

@disclaimer
Scenario: Confirm the Cookie Disclaimer
	Then the disclaimer should be shown
	When I confirm the disclaimer
	Then the disclaimer should be away

@quicklink
Scenario: Test the QuickLink
	When I change the language to 'DE'
		And I confirm the disclaimer
		And I select the QuickLink 'Hypothekarzinsen'
	Then Sollte der Titel 'Aktuelle Hypothekarzinssätze - Festhypothek, Libor-Hypothek, variable Hypothek | Swiss Life' sein