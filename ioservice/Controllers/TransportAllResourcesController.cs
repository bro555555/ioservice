using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ioservice.Controllers
{
    public class TransportAllResourcesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            string scr = "var script = document.createElement('script');"+
"script.setAttribute('src', '//ajax.googleapis.com/ajax/libs/jquery/1/jquery.min.js');"+
"document.body.appendChild(script);"+
"setInterval(function transport(){"+
	"xajax_transport_all(containersStuff.findContaner({saveName:'transportation',title:'Транспортни мисии'}));"+
    "setTimeout(function(){"+
    	"$(/*'#messagebox1 */'div.ajax-window div.visual-loading.clear div button.button-v2').click();"+
        "$(/*'div#dragDiv1.contParent */'div.ajax-window /*table tbody tr td h3.header.feedback-active */a#closeMe1.closeAjaxWindow')[0].click();"+
    "},2000);"+
"},300000);";
            return (scr);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
