﻿using Esafe_Team_Project.Data.Enums;

namespace Esafe_Team_Project.Models
{
    public class CertificateReqDto
    {

        public CertificateType CertificateType { get; set; }
        public int InterestPercentage { get; set; }
        public bool AutoRenewal { get; set; }

    }
}
