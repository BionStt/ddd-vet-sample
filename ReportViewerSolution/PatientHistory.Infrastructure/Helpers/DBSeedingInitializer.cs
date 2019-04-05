﻿using System;
using System.Data.Entity;
using PatientHistory.Domain.Entities;
using Repository;

namespace Repository.Helpers
{
  public class PatientHistoryDbSeedingInitializer:CreateDatabaseIfNotExists<PatientHistoryDataContext>
  {
    protected override void Seed(PatientHistoryDataContext context)
{
  context.Patients.Add
    (PatientInfo.CreatePatientInfoWithHistory(0,"Sampson", "Flynn", "Newfoundland", "Dog", 120,DateTime.Now,5, "watch tremor in rear legs")); 
      
      base.Seed(context);
}
     

  }
}
