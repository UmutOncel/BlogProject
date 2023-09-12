﻿using BlogProject.BLL.Services.Abstract;
using BlogProject.BLL.Services.Concrete;
using BlogProject.DAL.Abstract;
using BlogProject.DAL.Entities;
using BlogProject.DAL.UnitOfWorks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BlogProject.Web.Filters.ArticleVisitors
{
    public class ArticleVisitorFilter : IAsyncActionFilter
    {
        private readonly IVisitorRepository _visitorRepo;
        private readonly IUnitOfWork _unitOfWork;

        public ArticleVisitorFilter(IVisitorRepository visitorRepo, IUnitOfWork unitOfWork)
        {
            _visitorRepo = visitorRepo;
            _unitOfWork = unitOfWork;
        }


        //Amaç = Gelen kullanıcıları kaydetmek.
        public Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var visitors = _visitorRepo.GetAll().Result;

            //kullanıcının ip adresi alınır (MapToIPv4)
            string getIp = context.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
            string getUserAgent = context.HttpContext.Request.Headers["User-Agent"];
            
            Visitor visitor = new() { IpAddress = getIp, UserAgent = getUserAgent };

            //ziyaretçi ziyaretçilerimin içinde ise onu kaydetmiyoruz. her ziyaretçi 1 kez kaydedilecek. Aynı ıp adresine sahip kişiler visitor tablosuna kaydedilmiyor.
            if (visitors.Any(x => x.IpAddress == visitor.IpAddress))
            {
                return next();
            }
            else
            {
                _visitorRepo.Create(visitor);
                _unitOfWork.Save();
            }

            return next();
        }
    }
}
