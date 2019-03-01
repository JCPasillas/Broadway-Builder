﻿using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class ProductionJobService
    {
        private readonly BroadwayBuilderContext _dbContext;

        public ProductionJobService(BroadwayBuilderContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void CreateProductionJob(ProductionJobPosting productionJob)
        {
            _dbContext.ProductionJobPostings.Add(productionJob);
        }

        public ProductionJobPosting GetProductionJob(ProductionJobPosting productionJob)
        {
            return _dbContext.ProductionJobPostings.Find(productionJob.HelpWantedID);
        }

        public void UpdateProductionJob(TheaterJobPosting updatedProductionJob, TheaterJobPosting originalProductionJob)
        {
            if (originalProductionJob != null)
            {
                originalProductionJob.Title = updatedProductionJob.Title;
                originalProductionJob.Hours = updatedProductionJob.Hours;
                originalProductionJob.Position = updatedProductionJob.Position;
                originalProductionJob.Requirements = updatedProductionJob.Requirements;
                originalProductionJob.theater = updatedProductionJob.theater;
            }
        }

        public void DeleteProductionJob(ProductionJobPosting jobToRemove)
        {
            if (jobToRemove != null)
            {
                _dbContext.ProductionJobPostings.Remove(jobToRemove);
            }
        }
    }
}
