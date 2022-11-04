using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using backendTR.Data;
using backendTR.Models;

namespace backendTR.Controllers
{
    [Route("api/[controller]")]
    public class BpkbController : ControllerBase
    {
        private readonly TRAppsContext _context;

        public BpkbController(TRAppsContext context) => _context = context;

        //showing all data
        [HttpGet]
        public async Task<IEnumerable<tr_bpkb>> Get()
            => await _context.tr_bpkbs.ToListAsync();


        [HttpGet("GetLocation")]
        public async Task<IEnumerable<ms_storage_location>> GetLocation()
            => await _context.ms_storage_locations.ToListAsync();


        [HttpPost("AddBpkb")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult Create([FromBody] tr_bpkb bpkbRequest)
        {
            string Status = "";

            tr_bpkb bpkb = new tr_bpkb();
            bpkb.agreement_number = Guid.NewGuid().ToString();
            bpkb.bpkb_no = bpkbRequest.bpkb_no;
            bpkb.branch_id = bpkbRequest.branch_id;
            bpkb.bpkb_date = bpkbRequest.bpkb_date;
            bpkb.faktur_no = bpkbRequest.faktur_no;
            bpkb.faktur_date = bpkbRequest.faktur_date;
            bpkb.location_id = bpkbRequest.location_id;
            bpkb.police_no = bpkbRequest.police_no;
            bpkb.bpkb_date_in = bpkbRequest.bpkb_date_in;

            try
            {
                _context.tr_bpkbs.Add(bpkb);
                _context.SaveChanges();
                Status = "Success";

            }
            catch (Exception e)
            {
                Status = "Gagal";
                return StatusCode(500, "Error : " + e);
            }
            return Ok(Status);
        }

    }
}