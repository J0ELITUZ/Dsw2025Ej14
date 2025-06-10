namespace Dsw2025Ej14.Api.Domain
{
    public class Product
    {
    public string sku { get; set; }
	public string name { get; set; }
    public decimal currentUnitPrice { get; set; }
    public bool isActive { get; set; }

    }


        public interface IPersistencia
        {
            List<Product> ObtenerProductos();
        }
   

}
