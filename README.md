
# QnSTravelCount

Das Projekt 'QnSTravelCount' ist ein kleines datenzentriertes Anwendungsbeispiel mit welchem die Erstellung eines Software-Systems dargestellt werden soll. Dieses System wird mithilfe des '[QuickNSmart](https://github.com/leoggehrer/QuickNSmart)'-Framework erstellt. 

## Projekt

Zur Umsetzung des Projektes wird DotNetCore (3.1) als Framework, die Programmiersprache CSharp (C#) und die Entwicklungsumgebung Visual Studio 2019 Community verwendet. Alle Komponenten können kostenlos aus dem Internet heruntergeladen werden.

### Datenstruktur

Die Datenstruktur vom 'QnSTravelCount' ist überschaulich und besteht im wesentlichen aus 2 Komponenten welche in der folgenden Tabelle zusammengefasst sind:

|Komponente|Beschreibung|Grösse|Mussfeld|Eindeutig|
|---|---|---|---|---|
|**Travel**|Eine Reise ist die Zusammenfassung aller Kosten die auf dieser Reise entstanden sind.|
|*Designation*|Bezeichnung der Reise|256|Ja|Ja|
|*Description*|Bezeichnung der Reise|256|Nein|Nein|
|*Currency*|Bezeichnung der Währung|10|Ja|Nein|
|*Friends*|Angabe der Teilnehmer (Freunde) durch Semicolon getrennt|1024|Ja|Ja|
|*Category*|Kategorie (Bildungsreise, Urlaub,..) der Reise|64|Nein|Nein|
|**Expense**|Eine Kostenposition für eine Reise.|||
|*TravelId*|Fremdschüssel zur rise (Travel)|int|Ja|Nein|
|*Date*|Datum der Zahlung|DataTime|Ja|Nein|
|*Description*|Beschreibung der Kosten (Essen, Eintritt...)|128|Ja|Nein|
|*Friend*|Bezahlt vom Teilnehmer (Friend)|25|Ja|Nein|
|**Hinweis**|Alle Komponenten haben eine eindeutige Identität (Id)||||
|*|*Natürlich können noch weitere Attribute hinzugefügt werden.*||||

Aus dieser Definition kann ein entsprechendes Objektmodell abgeleitet werden, welches nachfolgend skizziert ist:

![Entities](Entities.png)

Wie aus der Abbildung leicht erkennbar ist, sind für alle Entitäten Schnittstellen definiert. Diese Schnittstellen sind im Projekt 
'QnSTravelCount.Contracts' im Ordner 'Persistence/App' definiert und dienen zur Interaktion mit den Entitätsobjekten außerhalb der Bibliothek. Das Model zeigt auch noch eine Basisklasse mit dem Namen 'IdentityObject'. Diese Klasse ist die Basisklasse für alle Entitäten im System und definiert die Identität der Objekte und beinhaltet die Eigenschaft, mit welcher die Identität eines Entitätstyp eindeutig bestimmt wird. Im Moment besteht diese Eigenschaft aus einer Id mit dem Datentyp Integer und wird vom System automatisch vergeben.  

## System-Erstellungs-Prozess

### Übersicht  

![Erstellungsprozess](QnSTravelCount_Create.png)

Als Ausgangsbasis wird der Framework 'QuickNSmart' verwendet. Diese Projekt wird mit Hilfe dem Hilfsprogramm 'SolutionCopier' in ein Verzeichnis nach eigener Wahl kopiert. In diesem Verzeichnis werden alle Projektteile vom Framework kopiert und die Namen der Projekte werden entsprechend angepasst. Alle Projekte mit einem domainspezifischen Namen werden durch den Namen des Verzeichnisses ersetzt.  

Zum Beispiel soll ein Projekt mit dem Namen 'QnSTravelCount' erstellt werden:

````csharp
string sourcePath = @"...\QnSTravelCount";
string targetPath = @"...\QnSTravelCount";

var sc = new SolutionCopier();

sc.Copy(sourcePath, targetPath);
````

Nach dem Ausführen vom SolutionCopier (*sc.Copy(sourcePath, targetPath)*) befindet sich folgende Verzeichnisstruktur in **QnSTravelCount**:  
- CommonBase
- CSharpCodeGenerator.ConApp
- QnSTravelCount.Contracts
- QnSTravelCount.Logic
- QnSTravelCount.Transfer
- QnSTravelCount.WebApi
- QnSTravelCount.Adapters
- QnSTravelCount.ConApp

Im Projekt 'QnSTravelCount' sind alle Code-Teile, welche als Basis-Code in andere Projekte verwendet werden können, mit einem Label '//@QnSCodeCopy' markiert. Dieser Label wird im Zielprojekt mit dem Label '//@QnSCodeCopy' ersetzt. Das hat den Vorteil, dass Änderungen im Framework auf die bereits bestehenden Projekte übertragen werden können (nähere Informationen dazu gibt es später).  

### Anpassen des Projektes  

Nach dem Erzeugen des 'Projektes' werden die Schnittstellen definiert und das Projekt Erstellt. Beim Erstellen wird zuerst das Schnittstellen-Projekt Kompiliert und nach deren Übersetzung wird der CSharpCodeGenerator.ConApp ausgeführt. Diese Ausführung wird mit dem Build-Event im Schnittstellen Projekt ausgeführt. Das Ausführen des Code-Generator hat 


**Viel Spaß beim Testen!**
