using AutoMapper;
using Application.Requests.CustomerRequests;
using Application.Requests.MenuItemRequestModel;
using Application.Requests.OrderItemsRequests;
using Application.Requests.OrderRequests;
using Application.Requests.PaymentRequests;
using Application.Requests.ReservationRequests;
using Application.Requests.TableRequests;
using Application.Responses.CustomerResponses;
using Application.Responses.MenuItemResponses;
using Application.Responses.OrderItemResponses;
using Application.Responses.OrderResponses;
using Application.Responses.PaymentResponses;
using Application.Responses.ReservationResponses;
using Application.Responses.TableResponses;
using Domain.Entities;


namespace Application.Mappers;

public class AutoMapperConfiguration : Profile
{
    public AutoMapperConfiguration() 
    {
        CreateMap<CreateCustomerRequestModel, Customer>();
        CreateMap<Customer, CustomerResponseModel> ();
        CreateMap<UpdateCustomerRequestModel, Customer>();

        CreateMap<CreateMenuItemRequestModel, MenuItem>();
        CreateMap<MenuItem, MenuItemResponseModel>();
        CreateMap<UpdateMenuItemRequestModel, MenuItem>();


        CreateMap<CreateOrderRequestModel, Order>();
        CreateMap<Order, OrderResponseModel>();
        CreateMap<UpdateOrderRequestModel, Order>();

        CreateMap<CreateOrderItemRequestModel, OrderItem>();
        CreateMap<OrderItem, OrderItemReponseModels>();
        CreateMap<UpdateOrderRequestModel, OrderItem>();

        CreateMap<CreatePaymentRequestModel, Payment>();
        CreateMap<Payment, PaymentResponseModel>();
        CreateMap<UpdateOrderRequestModel, Payment>();

        CreateMap<CreateReservationRequestModel, Reservation>();
        CreateMap<Reservation, ReservationResponseModel>();
        CreateMap<UpdateReservationRequestModel, Reservation>();

        CreateMap<CreateTableRequestModel, Table>();
        CreateMap<Table, TableResponseModel>();
        CreateMap<UpdateTableRequestModel, Table>();
    }
}
