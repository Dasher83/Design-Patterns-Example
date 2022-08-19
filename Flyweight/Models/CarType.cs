using System.Text.Json;
using Flyweight.DTOs;
using Flyweight.Interfaces;

namespace Flyweight.Models
{
    internal class CarType : IDataTransferable
    {
        private readonly string _company;
        private readonly string _model;
        private readonly string _color;

        public CarType(CarTypeDTO carTypeDTO)
        {
            _company = carTypeDTO.company;
            _model = carTypeDTO.model;
            _color = carTypeDTO.color;
        }

        public CarType(string company, string model, string color)
        {
            _company = company;
            _model = model;
            _color = color;
        }

        public string Company { get { return _company; } }
        public string Model { get { return _model; } }
        public string Color { get { return _color; } }

        public DTO GetDTO()
        {
            return new CarTypeDTO(company: _company, model: _model, color: _color);
        }
        public override string ToString()
        {
            return JsonSerializer.Serialize(new
            {
                Company = _company,
                Model = _model,
                Color = _color
            });
        }
    }
}
