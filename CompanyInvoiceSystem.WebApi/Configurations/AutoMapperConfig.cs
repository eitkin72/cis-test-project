using AutoMapper;
using CompanyInvoiceSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyInvoiceSystem.Common.Models.DataContracts;

namespace CompanyInvoiceSystem.WebApi.Configurations
{
    public static class AutoMapperConfig
    {
        private static Guid _newGuid = new Guid();
        private static IMapper _mapper { get; set; }

        static AutoMapperConfig()
        {
            var config = new MapperConfiguration(cfg =>
            {
                CompanyMapping(cfg);
                InvoiceMapping(cfg);
            });
            config.CompileMappings();
            _mapper = config.CreateMapper();
        }
        
        private static void CompanyMapping(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Company, CompanyServiceResponse>();
                //.ForMember(src => src.Id, opt => opt.MapFrom(dest => dest.Id == _newGuid ? null : dest.Id.ToString()));
            cfg.CreateMap<CompanyUpdateServiceRequest, Company>();
            cfg.CreateMap<CompanyCreateServiceRequest, Company>();
        }

        private static void InvoiceMapping(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Invoice, InvoiceServiceResponse>();
            cfg.CreateMap<InvoiceUpdateServiceRequest, Invoice>();
            cfg.CreateMap<InvoiceCreateServiceRequest, Invoice>();
        }


        public static TDestination Map<TSource, TDestination>(TSource source)
        {
            return _mapper.Map<TSource, TDestination>(source);
        }
        public static TDestination Map<TDestination>(object source)
        {
            return _mapper.Map<TDestination>(source);
        }
        public static TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            return _mapper.Map(source, destination);
        }
        public static object Map(object source, Type sourceType, Type destinationType)
        {
            return _mapper.Map(source, sourceType, destinationType);
        }
        public static object Map(object source, object destination, Type sourceType, Type destinationType)
        {
            return _mapper.Map(source, destination, sourceType, destinationType);
        }

    }
}
