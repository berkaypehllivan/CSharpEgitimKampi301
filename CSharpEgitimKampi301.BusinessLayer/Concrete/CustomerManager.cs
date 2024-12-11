﻿using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public List<Customer> TGetAll()
        {
            //if(yetki varsa)
            //{
            //listeme işlemini gerçekleştir
            //}
            //else
            //{
            //Hata mesajını gerçekleştir
            //}

            return _customerDal.GetAll();
        }

        public Customer TGetById(int Id)
        {
            return _customerDal.GetById(Id);
        }

        public void TInsert(Customer entity)
        {
            if (entity.CustomerName == "" && entity.CustomerName.Length >= 3 && entity.CustomerCity != null && entity.CustomerSurname != null && entity.CustomerName.Length <= 30)
            {
                _customerDal.Insert(entity);
            }
            else
            {
                //Hata mesajını gerçekleştir
            }

        }

        public void TUpdate(Customer entity)
        {
            _customerDal.Update(entity);
        }
    }
}