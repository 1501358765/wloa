 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDal;

namespace IDbSession
{
     public partial interface IDbSession
    {
IActionInfoDal ActionInfoDal { get; set;}


IBillDal BillDal { get; set;}


IBillTypesDal BillTypesDal { get; set;}


IBonusDal BonusDal { get; set;}


ICarDal CarDal { get; set;}


ICargoDal CargoDal { get; set;}


ICityDal CityDal { get; set;}


ICompensationDal CompensationDal { get; set;}


IDepartmentDal DepartmentDal { get; set;}


IEmployeeDal EmployeeDal { get; set;}


IHaulWayDal HaulWayDal { get; set;}


IMenuInfoDal MenuInfoDal { get; set;}


IOrderDal OrderDal { get; set;}


IPassByCityDal PassByCityDal { get; set;}


IPenaltyDal PenaltyDal { get; set;}


IProvinceDal ProvinceDal { get; set;}


IRoleDal RoleDal { get; set;}


ISalayDal SalayDal { get; set;}


ISizeChargeDal SizeChargeDal { get; set;}


IStationDal StationDal { get; set;}


IUserInfoDal UserInfoDal { get; set;}


IWeightChargeDal WeightChargeDal { get; set;}


	}
}