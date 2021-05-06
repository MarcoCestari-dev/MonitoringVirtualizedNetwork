# Gruppo
Siamo un gruppo composto dai seguenti studenti: Marco Cestari, Alissya Valer e Giada Figliolini. 
Abbiamo lavorato simultaneamnte a questo progetto, dividendoci i compiti.
I test sono stati effettuati sul computer centrale del gruppo, quello di Marco,
in quanto, essendo fisso, è il più potente e con maggiore affidabilità.

# Progetto
Il nostro progetto è "monitorning virtualized networks" 
e si compone di test e verifiche riguardanti le prestazioni dei container docker. 

# Strumenti utilizzati
 - Docker Desktop: per creare, gestire e visualizzare le risorse consumate 
 - Pumba: per simulare ritarsi, perdite e stress sui containers
 - Windows 10: per l'ambiente
 - Alpine, Pumba: Docker image

# Obiettivo del progetto
  - Abbiamo fatto diversi test, applicando ritardi fissi, variabili, perdite di pacchetti e limitazioni di banda con l'obiettivo di verificar come le risorse venivano utilizzate.

# Cosa abbiamo usato
  - Per la corretta esecuzione del programma in locale abbiamo utilizzato VISUAL STUDIO 2017 e  Visual C# per la creazione dell'interfaccia e del programma nel suo complesso.
  Per semplificarci l'inserimento dei comandi abbiamo creato diversi file .bat con l'obiettivo di attivare i comandi senza dover ogni volta aprire un cmd e dover copiare - incollare il comando (Ad esempio: HostA.bat contiene la stringa che serve per poter attivare un docker image chiamato HostA)

## Come abbiamo messo in comunicazione il programma con DOCKER STATS?
- L'ottenimento dei dati da Docker Desktop al programma effettivo è stato il compito più arduo. Siamo riusciti a far comunicare i due attravero C# in questa maniera:
1. Da C# apriamo quando necessario un CMD (nascosto all'utente) che manda il comando docker stats {.CPU} (cpu ad esempio) e ci ritorna nel cmd il valore della cpu in quel momento preciso dell'host attivo.
2. Attraverso sempre C# siamo riusciti a far leggere il CMD al programma e quindi il dato necessario.
3. Successivamente il dato viene elaborato per trasformarlo in DOUBLE (e non Stringa) e quindi utilizzarlo nei grafici.

# Come è possibile provare il programma
 - Per poter far funzionare il programma è necessario: 
 * Avere Docker Desktop installato con HyperV di windows ATTIVATO.
 * Avere i file bat dei comandi da attivare
 * Avere il file EXE e i file bat necessari per l'avviamento del programma (cpu.bat, mem.bat, link.bat, disk.bat)

- Una volta che si hanno tutti questi programmi è necessario aprirli IN QUESTO ORDINE:
1. Avviare Docker Desktop
2. Doppio click sul file bat per attivare UN HOST (ad esempio HostA.bat)
3. Doppio click sul file EXE per attivare il programma
4. Premere su "START MONITORING"
5. Una volta che non si vuole più monitorare premere STOP MONITORING

# Conclusioni
 - è stato notato che in tutti i nostri test, l’utilizzo delle risorse rimaneva invariato, 
   attivando sia i comandi per aggiungere ritardi che per inserire la perdita di pacchetti.
 - L’unico test che ha dato risultati inusuali è stato lo stress test, dove in alcuni casi, 
   attivando sia lo stress test che un ritardo fisso sullo stesso Host portava a il ritardo fisso 
   a diventare variabile. Inoltre, l’utilizzo delle risorse aumentava notevolmente.
 - Abbiamo sviluppato un’applicazione per monitorare, in real time, l’utilizzo delle risorse 
   tramite dei grafici che mostrano l’andamento della CPU, della RAM, 
   l’uso del disco e il collegamento (link). 
 - Abbiamo sviluppato l’intero applicativo in C# suddividendoci 
   i compiti nella maniera più uniforme possibile






