﻿using BusinessEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Interfaces
{
    public interface IAttractionsActiveStatus
    {
        GetAttractionOpenTime Admin_AttractionsActiveStatusGetOnAttractionsActiveStatusId(int AttractionsActiveStatusId);
    }
}
