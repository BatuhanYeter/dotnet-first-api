namespace FirstApi.Models
{
    public class ServiceResponse<T>
    {
        // for bigger projects, we may use this system to provide a proper response
        // T = generic, which allows us to compile without specifying a concrete type
        public T? Data { get; set; }
        public bool Success { get; set; } = true;

        public String Message { get; set; } = String.Empty;
    }
}
