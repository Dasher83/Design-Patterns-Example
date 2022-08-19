namespace Flyweight.DTOs
{
    internal class CarTypeDTO : DTO
    {
        public readonly string company;
        public readonly string model;
        public readonly string color;

        public CarTypeDTO(string company, string model, string color)
        {
            this.company = company;
            this.model = model;
            this.color = color;
        }
    }
}
