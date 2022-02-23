using realty.Data.Model;
using realty.Data.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace properties.Controllers.Data.Services
{
    public class pronatService
    {
        private AppdbContext _context;
        public pronatService(AppdbContext contex)
        {
            
                _context = contex;  

        }
        public void Addpronat (proonaVM pron)
        {
            var _pron = new pronat()
            {
                PropertyType = pron.PropertyType,
                PropertyCategory = pron.PropertCategory,
                City =pron.City,
                Zone =pron.Zone,
                Bedroom =pron.Bedroom,
                Area =pron.Area,
                Price =pron.Price,  

            };
            _context.pron.Add(_pron);
            _context.SaveChanges(); 
        }
        public List<pronat> GetAllPronat()
        {
            return _context.pron.ToList();

        }


    }
}
