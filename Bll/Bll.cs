 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBll;
using IDal;

namespace Bll
{
    using IDbSession;
    using System.Linq.Expressions;
    using Models;


 public  partial class ActionInfoBll : BaseBll<ActionInfo>, IActionInfoBll
    {

   
         public ActionInfoBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.ActionInfoDal;
        }
      
    }	

 public  partial class BillBll : BaseBll<Bill>, IBillBll
    {

   
         public BillBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.BillDal;
        }
      
    }	

 public  partial class BillTypesBll : BaseBll<BillTypes>, IBillTypesBll
    {

   
         public BillTypesBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.BillTypesDal;
        }
      
    }	

 public  partial class BonusBll : BaseBll<Bonus>, IBonusBll
    {

   
         public BonusBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.BonusDal;
        }
      
    }	

 public  partial class CarBll : BaseBll<Car>, ICarBll
    {

   
         public CarBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.CarDal;
        }
      
    }	

 public  partial class CargoBll : BaseBll<Cargo>, ICargoBll
    {

   
         public CargoBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.CargoDal;
        }
      
    }	

 public  partial class CityBll : BaseBll<City>, ICityBll
    {

   
         public CityBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.CityDal;
        }
      
    }	

 public  partial class CompensationBll : BaseBll<Compensation>, ICompensationBll
    {

   
         public CompensationBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.CompensationDal;
        }
      
    }	

 public  partial class DepartmentBll : BaseBll<Department>, IDepartmentBll
    {

   
         public DepartmentBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.DepartmentDal;
        }
      
    }	

 public  partial class EmployeeBll : BaseBll<Employee>, IEmployeeBll
    {

   
         public EmployeeBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.EmployeeDal;
        }
      
    }	

 public  partial class HaulWayBll : BaseBll<HaulWay>, IHaulWayBll
    {

   
         public HaulWayBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.HaulWayDal;
        }
      
    }	

 public  partial class MenuInfoBll : BaseBll<MenuInfo>, IMenuInfoBll
    {

   
         public MenuInfoBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.MenuInfoDal;
        }
      
    }	

 public  partial class OrderBll : BaseBll<Order>, IOrderBll
    {

   
         public OrderBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.OrderDal;
        }
      
    }	

 public  partial class PassByCityBll : BaseBll<PassByCity>, IPassByCityBll
    {

   
         public PassByCityBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.PassByCityDal;
        }
      
    }	

 public  partial class PenaltyBll : BaseBll<Penalty>, IPenaltyBll
    {

   
         public PenaltyBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.PenaltyDal;
        }
      
    }	

 public  partial class ProvinceBll : BaseBll<Province>, IProvinceBll
    {

   
         public ProvinceBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.ProvinceDal;
        }
      
    }	

 public  partial class RoleBll : BaseBll<Role>, IRoleBll
    {

   
         public RoleBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.RoleDal;
        }
      
    }	

 public  partial class SalayBll : BaseBll<Salay>, ISalayBll
    {

   
         public SalayBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.SalayDal;
        }
      
    }	

 public  partial class SizeChargeBll : BaseBll<SizeCharge>, ISizeChargeBll
    {

   
         public SizeChargeBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.SizeChargeDal;
        }
      
    }	

 public  partial class StationBll : BaseBll<Station>, IStationBll
    {

   
         public StationBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.StationDal;
        }
      
    }	

 public  partial class UserInfoBll : BaseBll<UserInfo>, IUserInfoBll
    {

   
         public UserInfoBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.UserInfoDal;
        }
      
    }	

 public  partial class WeightChargeBll : BaseBll<WeightCharge>, IWeightChargeBll
    {

   
         public WeightChargeBll(IDbSession dbSession):base(dbSession) 
        { 
         
        }

        public override void SetCurrentDal()
        {
            this.CurrentDal = session.WeightChargeDal;
        }
      
    }	
	
}