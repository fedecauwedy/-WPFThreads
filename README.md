# -WPFThreads
le lambda espressions sono utili quando si lavora con collezioni di oggetti. Inoltre sono utilizzate per filtrare collezioni di oggetti in base ad un criterio specifico, come ad esempio filtrare una lista di numeri per includere solo quelli pari. Un altro uso comune è per la programmazione asicrona, in questo caso vengono usate per definire funzioni di callback che vengono neseguite quando un'operazione asincrona viene completata.

Il costrutto 'lock' permette di sincronizare l'accesso concorrente a risorse condivise, come variabili e oggetti. Consente di evitare che più thread accedano in contemporanea alla stessa risorsa, che potrebbe portare risultati imprevedibili. 
la sintassi è:
lock (oggetto_sincronizzato)
{
//blocco di codice sincronizzato
}
