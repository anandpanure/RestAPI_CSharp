namespace Catalog.Dtos
{
    public record ItemDto
    {
        public Guid Id { get; init; } //init-only property - Setting value only when instantiation - immutable property    
        public string Name { get; init; }        
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }  
    }
}