﻿using System;
using System.Collections.Generic;
using System.Text;

namespace rednit.Domain
{
    class LikeSystem
    {
        public string UserID { get; set; }
        public string UserID_of_LikedUser { get; set; }

        public bool like = true;

        public void YesNo()
        {
            if (like)
            {


            }
            else
            {
                Console.WriteLine("GTFO");
            }
        }
    }
}
