Public Class Verhuis
    Public Property persoon As Persoon
    Public Property VanKlas As KlasNaam
    Public Property NaarKlas As KlasNaam
    Public Property VorigeKlasID As Integer

    Public Sub New(persoon As Persoon, vanklas As KlasNaam, vorigeklasID As Integer)
        Me.persoon = persoon
        Me.VanKlas = vanklas
        Me.NaarKlas = vanklas
        Me.VorigeKlasID = vorigeklasID
    End Sub
    Public Overrides Function ToString() As String
        'Return MyBase.ToString()
        Return persoon.ToString
    End Function
    Public Function ToStringGewijzigd(klasnaamLijst As List(Of KlasNaam)) As String
        'Return MyBase.ToString()
        Dim vanKlasNaam As String = klasnaamLijst.Where(Function(x) x.ID = VanKlas.ID).First.Naam
        Dim naarKlasNaam As String = klasnaamLijst.Where(Function(x) x.ID = NaarKlas.ID).First.Naam
        Return String.Format("{0} : {1} --> {2}", persoon.ToString, VanKlas.Naam, NaarKlas.Naam)
    End Function

    'UPDATE table_name
    'SET column1=value1,column2=value2,...
    'WHERE some_column=some_value;

    'INSERT INTO table_name (column1,column2,column3,...)
    'VALUES (value1,value2,value3,...);

    Public Shared Function KiesJaarVolgensDatum(datum As Date) As Integer
        If datum.Month >= 8 Then Return datum.Year Else Return datum.Year - 1
    End Function

    Public Shared Function UpdateVerhuis(verhuis As Verhuis, datum As Date) As OleDb.OleDbCommand
        Dim updateTekst As New OleDb.OleDbCommand
        Dim tijdFormat As String = "dd-MM-yyyy"

        With verhuis
            updateTekst.CommandText = String.Format("UPDATE TBL_Klas SET Stoptijdstip = '{0}' WHERE ID = {1}", datum.ToString(tijdFormat), .VorigeKlasID)
            updateTekst.Connection = GlobalVariables.conn
        End With

        Return updateTekst
    End Function
    Public Shared Function InsertVerhuis(verhuis As Verhuis, datum As Date) As OleDb.OleDbCommand
        Dim insertTekst As New OleDb.OleDbCommand
        Dim tijdFormat As String = "dd-MM-yyyy"
        With verhuis
            insertTekst.CommandText = String.Format("INSERT INTO TBL_Klas (Klas, Deelnemer, Starttijdstip, Schooljaar) VALUES ({0},{1},'{2}',{3})", .NaarKlas.ID, .persoon.ID, datum.Date.ToString(tijdFormat), .KiesJaarVolgensDatum(datum))
        End With
        insertTekst.Connection = GlobalVariables.conn
        Return insertTekst
    End Function
    Public Shared Function HoogsteID() As OleDb.OleDbCommand
        Dim hoogsteIndex As New OleDb.OleDbCommand


        'SELECT MAX(column_name) FROM table_name;


        hoogsteIndex.CommandText = "SELECT MAX(ID) FROM TBL_Klas"
        hoogsteIndex.Connection = GlobalVariables.conn


        Return hoogsteIndex
    End Function
End Class
