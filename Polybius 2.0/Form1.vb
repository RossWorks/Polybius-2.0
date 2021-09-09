Public Class Form_Start
    Dim testo_output As String 'testo che conterrà il messaggio di output
    Dim Testo_input As String 'variabile che verra utilizzata per memorizzare e manipolare il testo di input
    Dim Polibio_semplice(4, 4) As Char
    Dim Polibio_estesa(5, 5) As Char
    Dim current_index(1) As String 'diagonale principale della matrice attualmente in uso (semplice,estesa)

    Sub polibio_reset() Handles Me.Load 'la procedura riempie le matrici polibio non più con 61 righe di semplice assegnazione
        Dim I, J, L As Integer
        L = Asc("A") 'i cicli scorrono la matrice mentre la variabile L scorre le varie lettere. più piacevole da scrivere e più elegante
        For I = 0 To 4 ' questo For carica la matrice semplice
            For J = 0 To 4
                If (L = 74) Then 'c se la lettera da scrivere risulta essere la J, viene saltata
                    L += 1  'la J ha codice carattere (ASCII) 74
                End If
                Polibio_semplice(I, J) = Chr(L)
                L += 1
            Next J
        Next I
        L = Asc("A") 'resettiamo l'indice delle lettere
        For I = 0 To 5 'questo For carica la matrice estesa
            For J = 0 To 5
                If (L > 90) Then 'la Z ha codice ASCII 90, se il carattere ha codice superiore l'indice è spostato sull'inizio dei numeri
                    L = 48
                End If
                Polibio_estesa(I, J) = Chr(L)
                L += 1
            Next J
        Next I
        LblStatus.Text = "NORMALI"
        LblStatus.ForeColor = Color.Green
        current_index(0) = "AGNTZ"
        current_index(1) = "AHOV39"
        LblIndexSim.Text = current_index(0)
        LblIndexExt.Text = current_index(1)
    End Sub

    Sub carica_polibio_semplice(ByVal index As String, Optional ByRef check As String = Nothing)  'sub che riempie una matrice 4x4 partendo da una specificata lettera
        Dim L As Byte 'indice della lettera da scrivere
        Dim I, J As Integer
        L = Asc(index.Substring(0, 1)) 'si parte con la lettera passata come argomento
        For I = 0 To 4
            For J = 0 To 4
                If L = 74 Then 'si salta la J
                    L += 1
                End If
                If L > 90 Then ' Z = 90, se L va oltre ci si rimette sulla A
                    L = 65 'A = 65
                End If
                Polibio_semplice(I, J) = Chr(L) 'scriviamo la lettera
                L += 1
            Next J
        Next I
        For I = 0 To 4
            check &= Polibio_semplice(I, I)
        Next I
        LblStatus.Text = "MODIFICATE"
        LblStatus.ForeColor = Color.Red
    End Sub

    Sub controllo_carico() 'fa caricare una matrice dalla prima lettera dell'indice digitato, se la diagonale della matrice scritta è = all'indice digitato ok, altrimenti ripristina la matrice precedente
        Dim back_up As String = current_index(0) 'backup sarà sempre almeno l'indice della matrice regolare, dato che è creata all'avvio
        Dim indice = Nothing, controllo As String = Nothing
        indice = Txt_Index.Text
        Call carica_polibio_semplice(indice, controllo) 'in controllo sarà scritta la diagonale della matrice riscritta
        If indice <> controllo Then 'se il risultato della sub è <> da quello digitato la matrice è ripristinata
            Call carica_polibio_semplice(back_up, indice) 'back up sarà sempre un indice valido
        End If
        LblIndexSim.Text = indice
    End Sub

    Private Sub CMD_Cripta_Click(sender As Object, e As EventArgs) Handles CMD_Cripta.Click 'controlla l apresenza di testo e trasferisce l'elaborazione alla routine di rimozione accenti
        Testo_input = Nothing 'a ogni pressione del tasto le variabili di input e output sono resettate
        testo_output = Nothing
        If TxtInput.Text <> Nothing Then 'controlla che il testo di input non sia vuoto e lo memorizza nella variabile testo_generale
            TxtOutput.Text = Nothing
            Testo_input = TxtInput.Text.ToUpper 'il testo è trasformato in maiuscole
            Call normalizza()
        Else
            MessageBox.Show("Il testo di input è vuoto!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Sub normalizza() 'rimuove gli accenti
        Testo_input.Replace(" ", Nothing)
        Dim testo() As Char = Testo_input.ToCharArray 'trasferisce il testo_generale in un vettore per l'analisi carattere dopo carattere
        Dim I As Int32 = 0
        For I = 0 To testo.Length - 1 'controllo passo-passo: sostituzione accenti con caratteri normali
            Select Case testo(I)
                Case "À" 'i caratteri sono maiuscoli! case sensitive!
                    testo(I) = "A"
                Case "É"
                    testo(I) = "E"
                Case "È"
                    testo(I) = "E"
                Case "Ì"
                    testo(I) = "I"
                Case "Ò"
                    testo(I) = "O"
                Case "Ù"
                    testo(I) = "U"
                Case "Ç"
                    testo(I) = "C"
            End Select
        Next I
        Testo_input = testo
        If Btn_Semplice.Checked = True Then 'controllo per decidere tra polibio semplice ed estesa
            Call codifica(Polibio_semplice, 4) 'dimensione = 4 perchè la matrice va da zero a 4
        ElseIf Btn_Estesa.Checked = True Then
            Call codifica(Polibio_estesa, 5)
        End If
    End Sub

    Sub codifica(ByRef matrice(,) As Char, ByVal dimensione As Integer) ' le decodifiche raggrupperanno di nuovo tutte le cifre, le divisioni non saranno rilevanti
        Dim I, J, K As Integer
        Dim conditio = False, char_crit As Boolean = False 'char_crit tiene conto se il precedente carattere è stato crittato, la schacchiera va mantenuta invariata fino alla crittazione di una lettera
        For K = 0 To Testo_input.Length - 1
            conditio = Chk_Scorr.Checked And (K > 0) And char_crit 'devo aver selezionato lo scorrimento, aver già analizzato il primo carattere e critato con successo il precedente carattere
            If conditio Then
                Call Scorrimento(matrice, dimensione) ' se conditio è vera allora posso spostare le lettere nella scacchiera
            End If
            char_crit = False
            For I = 0 To dimensione
                For J = 0 To dimensione
                    If Testo_input.Substring(K, 1) = matrice(I, J) Then 'nel caso in cui il carattere non appaia nella matrice, verrà saltato senza avvisi o errori
                        testo_output &= I + 1 & J + 1 'in questa versione (2.0) i numeri verranno scritti tutti attaccati. una prossima sub permetterà di decidere come raggruppare le cifre.
                        char_crit = True
                    End If
                Next J
            Next I
        Next K
        If NumGroup.Value = 0 Then
            TxtOutput.Text = testo_output
        Else
            I = 0
            For I = 0 To testo_output.Length - 1
                TxtOutput.Text &= testo_output.Substring(I, 1)
                If (I + 1) Mod NumGroup.Value = 0 Then
                    TxtOutput.Text &= " "
                End If
            Next I
            TxtOutput.Text.Trim()
        End If
    End Sub

    Private Sub CMD_Open_Click(sender As Object, e As EventArgs) Handles CMD_Open.Click
        Dim DIR As String
        Try
            OpenFileDialog1.ShowDialog() 'mostro la finestra per selezionare un file di testo (con filtro) da aprire
            DIR = OpenFileDialog1.FileName 'il percorso è immagazzinato nella variabile DIR
            TxtInput.Text = My.Computer.FileSystem.ReadAllText(DIR) 'leggo tutto il file e lo trasferisco in txtInput.text (la casella di testo di input)
        Catch IO As IO.IOException 'eccezione se il file non può essere usato per qualsiasi ragione (difficilissimo che accada)
            MessageBox.Show(IO.Message)
        Catch perc_errato As ArgumentException 'OpenFileDialog controlla se il percorso del file è valido e se il file esiste. l'unica possibilità di avere questo errore è premere annulla nella finestra di dialogo
            'qui non fa nulla se il percorso non è valido (per esempio viene premuto annulla nell'apertura del file)
        Catch troppo_grande As OutOfMemoryException
            MessageBox.Show(troppo_grande.Message)
        End Try
    End Sub

    Private Sub Cmd_Save_Click(sender As Object, e As EventArgs) Handles Cmd_Save.Click
        Dim DIR As String
        If (TxtOutput.Text = Nothing) Or (testo_output = Nothing) Then
            MessageBox.Show("Impossibile salvare il file.", "salvataggio file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        SaveFileDialog1.ShowDialog()
        DIR = SaveFileDialog1.FileName
        My.Computer.FileSystem.WriteAllText(DIR, testo_output, False)
    End Sub

    Private Sub Cmd_Decripta_Click(sender As Object, e As EventArgs) Handles Cmd_Decripta.Click
        Testo_input = Nothing
        testo_output = Nothing
        If TxtInput.Text <> Nothing Then
            Testo_input = TxtInput.Text
            Call Controllo_qualita()
        Else
            MessageBox.Show("Il testo di input è vuoto: inserire un testo.", "Testo vuoto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub Controllo_qualita()
        Dim check_char As Char 'un carattere è utilizzato per analizzare uno per uno i caratteri dell'input: meno memoria utilizzata
        Dim I, K As Integer
        Testo_input = Testo_input.Replace(" ", String.Empty) 'tutti gli spazi bianchi sono eliminati il carattere nullo è dato da string.empty
        If Testo_input.Length Mod 2 <> 0 Then 'ogni lettera è una coppia di cifre: tutti i testi cifrati avranno lunghezza pari
            MessageBox.Show("Errore: stringa non creata col cifrario polibio.", "Errore di input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        For I = 0 To Testo_input.Length - 1
            check_char = Testo_input.Substring(I, 1)
            If IsNumeric(check_char) = True Then 'il carattere è numerico viene controllato
                K = Microsoft.VisualBasic.Val(check_char) 'questa funzione permette il cast da char a integer
                If Btn_Semplice.Checked Then
                    If (K < 1) Or (K > 5) Then 'range possibile per la codifica semplice (5x5)
                        MessageBox.Show("Errore: stringa non creata col cifrario polibio.", "Errore di input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                ElseIf Btn_Estesa.Checked Then
                    If (K < 1) Or (K > 6) Then 'range per la codifica estesa (6x6)
                        MessageBox.Show("Errore: stringa non creata col cifrario polibio.", "Errore di input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
            Else
                MessageBox.Show("Errore: stringa non creata col cifrario polibio.", "Errore di input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next I
        If Btn_Estesa.Checked Then 'l'appropriata decodifica è avviata
            Call decodifica(Polibio_estesa, 5)
        ElseIf Btn_Semplice.Checked Then
            Call decodifica(Polibio_semplice, 4)
        End If
    End Sub

    Sub decodifica(ByRef matrice(,) As Char, ByVal dimensione As Integer) 'passando la matrice su cui operare come parametro, non serve più avere due versioni di codifica e decodifica
        Dim I, R, C As Integer
        For I = 0 To Testo_input.Length - 1 Step 2
            If Chk_Scorr.Checked And I > 0 Then
                Call Scorrimento(matrice, dimensione)
            End If
            R = Testo_input.Substring(I, 1)
            C = Testo_input.Substring(I + 1, 1)
            testo_output &= matrice(R - 1, C - 1)
        Next I
        TxtOutput.Text = testo_output
    End Sub

    Sub Scorrimento(ByRef matrice(,) As Char, ByVal dimensione As Integer) 'vedere il file scorrimento.txt per dettagli su questa routine
        Dim I, J As Integer 'fa scorrere la matrice semplice
        Dim AUX(5) As Char 'vettore ausiliario
        Dim RES As Char 'carattere ausiliario
        LblStatus.Text = "MODIFICATE"
        LblStatus.ForeColor = Color.Red
        For I = 0 To dimensione
            AUX(I) = matrice(I, 0) 'carico il vettore ausiliario
        Next I
        RES = AUX(0)
        For I = 0 To dimensione
            For J = 0 To dimensione - 1
                matrice(I, J) = matrice(I, J + 1) 'sposto le colonne di polibio indietro di uno
            Next J
        Next I
        For I = 0 To dimensione - 1 'effettuo uno shift indietro di una posizione senza perdere valori
            AUX(I) = AUX(I + 1)
        Next I
        AUX(dimensione) = RES
        For I = 0 To dimensione
            matrice(I, dimensione) = AUX(I) 'riempio la colonna di polibio liberata
        Next I
        If dimensione = 4 Then 'qui vediamo che indice aggiornare i possibili valori sono 4 e 5
            current_index(0) = Nothing
            For I = 0 To dimensione
                current_index(0) &= matrice(I, I)
            Next I
            LblIndexSim.Text = current_index(0)
        Else
            current_index(1) = Nothing
            For I = 0 To dimensione
                current_index(1) &= matrice(I, I)
            Next I
            LblIndexExt.Text = current_index(1)
        End If
    End Sub

    Private Sub Cmd_Reset_Reset(sender As Object, e As EventArgs) Handles Button1.Click
        Call polibio_reset()
    End Sub

    Private Sub Cmd_Load_Click(sender As Object, e As EventArgs) Handles Cmd_Load.Click 'sub che controlla che l'indice inserito abbia la lunghezza appropriata
        Dim A As Integer = Txt_Index.Text.Length
        Select Case A
            Case 5
                Call controllo_carico()
            Case Else
                MessageBox.Show("Nessun indice valido specificato", "Indice di codifica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Select
    End Sub

End Class