Module Module1

    Sub Main()
        Dim doc As XElement =
<Agenda Tipo="Pessoal">
    <!--Exemplo XML-->
    <Contato Nome="Agnaldo">
        <email>agnaldo@50minutos.com.br</email>
        <telefone>11-1234-4321</telefone>
    </Contato>
    <Contato Nome="Netinho">
        <email>netinho@50minutos.com.br</email>
        <telefone>11-1234-4321</telefone>
    </Contato>
    <Contato Nome="Renata">
        <email>renata@50minutos.com.br</email>
        <telefone>11-5432-7070</telefone>
    </Contato>
</Agenda>

        Console.WriteLine(doc.ToString())

        Console.ReadKey()
    End Sub

End Module
