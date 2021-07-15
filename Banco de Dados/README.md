# SQL Server

* [Banco de Dados Relacional](https://github.com/relex337/AllContents/edit/main/Banco%20de%20Dados#banco-de-dados-relacional)
* [CRUD](https://github.com/relex337/AllContents/edit/main/Banco%20de%20Dados#crud)
* [Comandos](https://github.com/relex337/AllContents/edit/main/Banco%20de%20Dados#comandos)
* [W3Schools](https://github.com/relex337/AllContents/edit/main/Banco%20de%20Dados#w3schools)
* [Implementando no C#](https://github.com/relex337/AllContents/edit/main/Banco%20de%20Dados#implementando-no-c#)


## Banco de Dados Relacional

Um banco de dados é uma aplicação que lhe permite armazenar e obter de volta dados com eficiência. 
O que o torna relacional é a maneira como os dados são armazenados e organizados no banco de dados.

Em um banco de dados relacional, todos os dados são guardados em tabelas. Estas têm uma estrutura que se repete a cada linha, como você pode observar em uma planilha. 
São os relacionamentos entre as tabelas que as tornam “relacionais”.

## CRUD
  * Create - INSERT
  * Read - SELECT
  * Update - UPDATE
  * Destroy - DELETE

## Comandos

Lista completa de comandos: [w3schools.com](https://www.w3schools.com/sql/exercise.asp?filename=exercise_select1)

### [CREATE](https://www.w3schools.com/sql/sql_create_table.asp)

```sql
  CREATE TABLE TABLE_NAME
  (
    COLUMN1 DATATYPE,
    COLUMN2 DATATYPE,
    COLUMN3 DATATYPE,
    ...
  )
```

### [INSERT](https://www.w3schools.com/sql/sql_ref_insert_into.asp)

```sql
  INSERT INTO TABLE_NAME (COLUMN_NAME1, COLUMN_NAME2) VALUES ('COLUMN1 VALUE', 'COLUMN2 VALUE')
```

### [SELECT](https://www.w3schools.com/sql/sql_ref_select.asp)

```sql
  SELECT * FROM TABLE_NAME
```

### [UPDATE](https://www.w3schools.com/sql/sql_ref_update.asp)

```sql
  UPDATE TABLE_NAME SET COLUMN_NAME = 'VALUE' WHERE ID = 0
```

### [DELETE](https://www.w3schools.com/sql/sql_ref_delete.asp)

```sql
  DELETE FROM TABLE_NAME WHERE ID = 0
```

## W3schools

Caso queira aprender mais sobre _SQL Server_, recomendo dar uma olhada no site [w3schools](https://www.w3schools.com/sql/sql_ref_keywords.asp)

## Implementando no C#

Um exemplo básico de como implementar o banco de dados _SQL Server_ no c#.

```csharp
using System;
using System.Data.SqlClient;

class MyClass
{
    public MyClass()
    {
        Example example = new Example();

        string connectionString = @"DataBaseConnectionString";
        SqlConnection sqlConnection = new SqlConnection(connectionString);

        SqlCommand sqlCommand = new SqlCommand();
        sqlCommand.Connection = sqlConnection;

        sqlCommand.CommandText = "INSERT INTO TABLE_NAME (COLUMN1_NAME, COLUMN2_NAME) VALUES (@COLUMN1_VALUE, @COLUMN2_VALUE";
        sqlCommand.Parameters.AddWithValue("@COLUMN1_VALUE", example.Name);
        sqlCommand.Parameters.AddWithValue("@COLUMN2_VALUE", example.Email);

        try
        {
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            sqlConnection.Dispose();
        }
    }
}
```
