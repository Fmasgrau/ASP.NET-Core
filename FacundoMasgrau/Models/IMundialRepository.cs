using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacundoMasgrau.Models
{
    public interface IMundialRepository
    {
        IEnumerable<Mundial> GetAllMundials();
        Mundial GetMundialById(int mundialId);
    }
}
