using Microsoft.AspNetCore.Mvc;
using WebApiProject.Models;

namespace WebApiProject.Controllers;


[ApiController]
[Route("converter")]

public class ConverterContoller : ControllerBase{
    public class Distance{
        public int Miles {get; set;}
        public double Kilometers {get; set;}
    }
   
    [HttpGet("CoverMileage")]
    public double ConvertMilage(int milesPerGallon){
        return milesPerGallon * 0.42;
    }

    [HttpGet("ConvertMiles")]
    public Distance ConvertMiles(int miles){
        double km = miles*1.609;
        return new Distance(){Miles=miles, Kilometers=km};
    }
    
    [HttpPost("convert")]
    public List<ConversionResponse> ConvertValues([FromBody] ConversionRequest Request)
    {
        return new ConversionResponse().ConvertValues(Request);
    }
}