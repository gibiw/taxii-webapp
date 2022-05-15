using Microsoft.AspNetCore.Mvc;

namespace Taxii.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CollectionsController : ControllerBase
    {
        private readonly ILogger<CollectionsController> _logger;

        public CollectionsController(ILogger<CollectionsController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public string GetFeeds()
        {
            var res = "{\"max_content_length\": 1000000, \"title\": \"TAXII feeds\", \"versions\": [\"taxii - 2.0\"]}";

            return res;
        }

        [HttpGet()]
        [Route("feeds")]
        public string Get()
        {
            var res = "{\"collections\": [{\"can_read\": true,\"can_write\": false,\"description\": \"\",\"id\": \"110\",\"title\": \"Phish Tank\"},{\"can_read\": true,\"can_write\": false,\"description\": \"\",\"id\": \"67394485-b4dc-4628-b3a2-079000fee115\",\"title\": \"Abuse.ch Ransomware IPs\"}]}";

        return res;
        }

        [HttpGet()]
        [Route("feeds/{id}")]
        public string GetCollection([FromRoute] string id)
        {
            switch (id) {
                case "110":
                    return "{\"can_read\": true, \"can_write\": false, \"description\": \"\", \"id\": \"110\", \"title\": \"Phish Tank\"}";
                case "67394485-b4dc-4628-b3a2-079000fee115":
                    return "{\"can_read\": true,\"can_write\": false,\"description\": \"\",\"id\": \"67394485-b4dc-4628-b3a2-079000fee115\",\"title\": \"Abuse.ch Ransomware IPs\"}";
                default: return "";
            }
        }

        [HttpGet()]
        [Route("feeds/{id}/objects")]
        public string GetItems([FromRoute] string id)
        {
            switch (id)
            {
                case "110":
                    return "{\"id\": \"bundle--70ec1e8c-733e-418b-bbe1-1e5dd33c9f43\",\"objects\": [{\"created\": \"2016-02-26T18:11:48.479Z\",\"description\": \"TS ID: 37323558; iType: phish_url; State: active; Org: Web Werks; Source: Phish Tank\",\"id\": \"indicator--5aabc09b-6c50-4259-98b2-c2577f446a31\",\"labels\": [\"malicious-activity\",\"threatstream-severity-very-high\",\"threatstream-confidence-85\"],\"modified\": \"2016-02-26T18:11:48.479Z\",\"name\": \"phish_url: http://www.srbiohealth.com/London1/Eruku/nD/index.php\",\"object_marking_refs\": [\"marking-definition--34098fce-860f-48ae-8e50-ebd3cc5e41da\"],\"pattern\": \"[url:value = 'http://www.srbiohealth.com/London1/Eruku/nD/index.php']\",\"type\": \"indicator\",\"valid_from\": \"2016-02-26T18:11:48.479Z\"},{\"created\": \"2016-02-26T18:11:49.452Z\",\"description\": \"TS ID: 37323554; iType: phish_url; State: active; Org: CyrusOne LLC; Source: Phish Tank\",\"id\": \"indicator--0da61560-61b1-473d-a685-28bebfb4c5ab\",\"labels\": [\"malicious-activity\",\"threatstream-severity-very-high\",\"threatstream-confidence-85\"],\"modified\": \"2016-02-26T18:11:49.452Z\",\"name\": \"phish_url: http://dayamino.com/New/\",\"object_marking_refs\": [\"marking-definition--34098fce-860f-48ae-8e50-ebd3cc5e41da\"],\"pattern\": \"[url:value = 'http://dayamino.com/New/']\",\"type\": \"indicator\",\"valid_from\": \"2016-02-26T18:11:49.452Z\"}],\"spec_version\": \"2.0\",\"type\": \"bundle\"}";
                case "67394485-b4dc-4628-b3a2-079000fee115":
                    return "{\"id\": \"bundle--70ec1e8c-733e-418b-bbe1-1e5dd33c9f43\",\"objects\": [{\"created\": \"2016-02-26T18:11:48.479Z\",\"description\": \"TS ID: 37323558; iType: phish_url; State: active; Org: Web Werks; Source: Phish Tank\",\"id\": \"indicator--5aabc09b-6c50-4259-98b2-c2577f446a31\",\"labels\": [\"malicious-activity\",\"threatstream-severity-very-high\",\"threatstream-confidence-85\"],\"modified\": \"2016-02-26T18:11:48.479Z\",\"name\": \"phish_url: http://www.srbiohealth.com/London1/Eruku/nD/index.php\",\"object_marking_refs\": [\"marking-definition--34098fce-860f-48ae-8e50-ebd3cc5e41da\"],\"pattern\": \"[url:value = 'http://www.srbiohealth.com/London1/Eruku/nD/index.php']\",\"type\": \"indicator\",\"valid_from\": \"2016-02-26T18:11:48.479Z\"},{\"created\": \"2016-02-26T18:11:49.452Z\",\"description\": \"TS ID: 37323554; iType: phish_url; State: active; Org: CyrusOne LLC; Source: Phish Tank\",\"id\": \"indicator--0da61560-61b1-473d-a685-28bebfb4c5ab\",\"labels\": [\"malicious-activity\",\"threatstream-severity-very-high\",\"threatstream-confidence-85\"],\"modified\": \"2016-02-26T18:11:49.452Z\",\"name\": \"phish_url: http://dayamino.com/New/\",\"object_marking_refs\": [\"marking-definition--34098fce-860f-48ae-8e50-ebd3cc5e41da\"],\"pattern\": \"[url:value = 'http://dayamino.com/New/']\",\"type\": \"indicator\",\"valid_from\": \"2016-02-26T18:11:49.452Z\"}],\"spec_version\": \"2.0\",\"type\": \"bundle\"}";
                default: return "";
            }
        }
    }
}