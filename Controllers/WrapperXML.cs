using Microsoft.AspNetCore.Mvc;
using practiquesIEI.Wrappers;

namespace WrapperXML.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WrapperXML : ControllerBase
    {
        [HttpGet("XmlToJson")]
        public async Task<IActionResult> WrapperCAT()
        {
            try
            {
                string xmlFileName = "CAT.xml";
                string xmlFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Fuentes de datos", xmlFileName);
                string jsonFromXml = XmlWrapper.ConvertXmlToJson(xmlFilePath);

                return Ok(jsonFromXml);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error en el wrapper para WrapperXml: {ex.Message}");
            }
        }
    }
}
