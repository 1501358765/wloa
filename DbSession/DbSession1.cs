 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDal;

namespace DbSession
{
    public partial class DbSession : IDbSession.IDbSession
    {

 public IActionInfoDal ActionInfoDal { get; set; }


 public IBillDal BillDal { get; set; }


 public IBillTypesDal BillTypesDal { get; set; }


 public IBonusDal BonusDal { get; set; }


 public ICarDal CarDal { get; set; }


 public ICargoDal CargoDal { get; set; }


 public ICityDal CityDal { get; set; }


 public ICompensationDal CompensationDal { get; set; }


 public IDepartmentDal DepartmentDal { get; set; }


 public IEmployeeDal EmployeeDal { get; set; }


 public IHaulWayDal HaulWayDal { get; set; }


 public IMenuInfoDal MenuInfoDal { get; set; }


 public IOrderDal OrderDal { get; set; }


 public IPassByCityDal PassByCityDal { get; set; }


 public IPenaltyDal PenaltyDal { get; set; }


 public IProvinceDal ProvinceDal { get; set; }


 public IRoleDal RoleDal { get; set; }


 public ISalayDal SalayDal { get; set; }


 public ISizeChargeDal SizeChargeDal { get; set; }


 public IStationDal StationDal { get; set; }


 public IUserInfoDal UserInfoDal { get; set; }


 public IWeightChargeDal WeightChargeDal { get; set; }

	}
}