public class Location : BaseEntity
{
    public int warehouse_id { get; set; }
    public string code { get; set; }
    public string name { get; set; }
    public ICollection<Inventory> inventories { get; set; }
}

// public class Location : BaseEntity
// {
//     public int warehouse_id { get; set; }
//     public string code { get; set; }
//     public string name { get; set; }


// }