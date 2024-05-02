using Npgsql;

namespace FastShop.DataAccess.Repositories;

public class BaseRepository
{
    protected readonly NpgsqlConnection _connection;

    public BaseRepository()
    {
        this._connection = new NpgsqlConnection("Host = localhost; Port = 5432; Database = fast-shop-db; User Id = postgres; Password = @20112606;");
    }
}
