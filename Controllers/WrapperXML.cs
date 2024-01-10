using Microsoft.AspNetCore.Mvc;
using practiquesIEI.Wrappers;

namespace WrapperXML.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WrapperXML : ControllerBase
    {
        [HttpGet("XmlToJson")]
        public async Task<IActionResult> ExtractCV()
        {
            try
            {
                string csvFileName = "CAT.xml";
                string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Fuentes de datos", csvFileName);
                string jsonFromCsv = XmlWrapper.ConvertXmlToJson(csvFilePath);

                return Ok(jsonFromCsv);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error en la extracción para CVextractor: {ex.Message}");
            }
        }
    }
}
