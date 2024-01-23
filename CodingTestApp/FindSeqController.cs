using Microsoft.AspNetCore.Mvc;
namespace CodingTestApp;

[ApiController]
[Route("api/FindSeqController")]
public class FindSeqController : ControllerBase
{
   [HttpGet]
    public string GetString(string inputString)
    {
        string output = "";
        if(inputString == null)
        {
            NotFound();
        }
        else
       output = FindSeq.FindLongestSequence(inputString);
       return output;
    }

}
