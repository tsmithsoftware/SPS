using System.Data.Entity.Core.Objects;
using ADOv2.Interfaces;
using ADOv2.Models;
using System.Configuration;
using ADOv2.Repositories;

namespace ADOv2.UnitsOfWork
{
    public class SqlUnitOfWork : IUnitOfWork
    {
        const string connectionStringName = "SqlDatabaseString";
        readonly ObjectContext _context = null;
        private SqlRepository<Bid> _bids = null;
        private SqlRepository<Customer> _customers = null;
        private SqlRepository<Provider> _providers = null;
        private SqlRepository<ServiceRequest> _requests = null;
        private SqlRepository<Service> _services = null;
        private SqlRepository<ServicesProvided> _servicesProvided = null;
        public SqlUnitOfWork()
        {
            var connectionString =
            ConfigurationManager
                .ConnectionStrings[connectionStringName]
                .ConnectionString;
            _context = new ObjectContext(connectionString);
        }
        public IRepository<Bid> Bids
        {
            get
            {
                if (_bids == null)
                {
                    _bids = new SqlRepository<Bid>(_context);
                }
                return _bids;
            }
        }

        public IRepository<Customer> Customers
        {
            get
            {
                if (_customers == null)
                {
                    _customers = new SqlRepository<Customer>(_context);
                }
                return _customers;
            }
        }

        public IRepository<Provider> Providers
        {
            get
            {
                if (_providers == null)
                {
                    _providers = new SqlRepository<Provider>(_context);
                }
                return _providers;
            }
        }

        public IRepository<ServiceRequest> ServiceRequests
        {
            get
            {
                if (_requests == null)
                {
                    _requests = new SqlRepository<ServiceRequest>(_context);
                }
                return _requests;
            }
        }

        public IRepository<Service> Services
        {
            get
            {
                if (_services == null)
                {
                    _services = new SqlRepository<Service>(_context);
                }
                return _services;
            }
        }

        public IRepository<ServicesProvided> ServicesProvided
        {
            get
            {
                if (_servicesProvided == null)
                {
                    _servicesProvided = new SqlRepository<ServicesProvided>(_context);
                }
                return _servicesProvided;
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
