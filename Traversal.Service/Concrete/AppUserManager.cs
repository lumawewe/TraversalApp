using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Concrete;
using Traversal.Repository.Abstract;
using Traversal.Service.Abstract;

namespace Traversal.Service.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserRepository _appUserRepository;

        public AppUserManager(IAppUserRepository appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }

        public void TAdd(AppUser t)
        {
            _appUserRepository.Add(t);
        }

        public void TDelete(AppUser t)
        {
            _appUserRepository.Delete(t);
        }

        public AppUser TGetByID(int id)
        {
            return _appUserRepository.GetById(id);
        }

        public List<AppUser> TGetList()
        {
            return _appUserRepository.GetList();
        }

        public void TUpdate(AppUser t)
        {
            _appUserRepository.Update(t);
        }
    }
}
