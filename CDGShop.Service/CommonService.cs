﻿using CDGShop.Common;
using CDGShop.Data.Infrastructure;
using CDGShop.Data.Repositories;
using CDGShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDGShop.Service
{
    public interface ICommonService
    {
        Footer GetFooter();

        IEnumerable<Slide> GetSlides();
    }

    public class CommonService : ICommonService
    {
        private IFooterRepository _footerRepository;
        private IUnitOfWork _unitOfWork;
        private ISlideRepository _slideRepository;

        public CommonService(IFooterRepository footerRepository, IUnitOfWork unitOfWork, ISlideRepository slideRepository)
        {
            _footerRepository = footerRepository;
            _unitOfWork = unitOfWork;
            _slideRepository = slideRepository;
        }

        public Footer GetFooter()
        {
            return _footerRepository.GetSingleByCondition(x => x.ID == CommonConstants.DefaultFooterId);
        }

        public IEnumerable<Slide> GetSlides()
        {
            return _slideRepository.GetMulti(x => x.Status);
        }
    }
}