using System;

namespace BuilderPatternExample
{
    public class Engine
    {
        public double Power { get; set; }

        public Engine(double power)
        {
            this.Power = power;
        }
    }

    public enum Transmission
    {
        MANUAL,
        AUTOMATIC,
        AUTOMATIC_SEQUENTIAL
    }

    public enum VehicleType
    {
        SEDAN,
        SPORTCAR,
        PICKUPTRUCK,
        TRUCK,
        SUV
    }

    // IBuilder 
    public interface IBuilder
    {
        void Reset();
        Vehicle GetVehicle();
        void SetSeats(int seats);
        void SetEngine(Engine engine);
        void SetTransmission(Transmission transmission);
        void SetVehicleType(VehicleType vehicleType);
        void SetAirbag(bool hasAirbag); // 
    }

    // Produto Veiculo
    public class Vehicle
    {
        public int Seats { get; set; }
        public Engine Engine { get; set; }
        public Transmission Transmission { get; set; }
        public VehicleType VehicleType { get; set; }
        public bool Airbag { get; set; }  

        public Vehicle() { }

        public override string ToString()
        {
            return $"Vehicle Type: {VehicleType}, Seats: {Seats}, Engine Power: {Engine?.Power} HP, " +
                   $"Transmission: {Transmission}, Airbag: {(Airbag ? "Yes" : "No")}";
        }
    }

    // CarBuilder 
    public class CarBuilder : IBuilder
    {
        private Vehicle _vehicle;

        public CarBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _vehicle = new Vehicle();
        }

        public Vehicle GetVehicle()
        {
            Vehicle builtVehicle = _vehicle;
            Reset();
            return builtVehicle;
        }

        public void SetSeats(int seats)
        {
            _vehicle.Seats = seats;
        }

        public void SetEngine(Engine engine)
        {
            _vehicle.Engine = engine;
        }

        public void SetTransmission(Transmission transmission)
        {
            _vehicle.Transmission = transmission;
        }

        public void SetVehicleType(VehicleType vehicleType)
        {
            _vehicle.VehicleType = vehicleType;
        }

        public void SetAirbag(bool hasAirbag)
        {
            _vehicle.Airbag = hasAirbag;
        }
    }

    // Diretor
    public class Director
    {
        private IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

   
        public void ConstructSedanCar()
        {
            _builder.Reset();
            _builder.SetVehicleType(VehicleType.SEDAN);
            _builder.SetSeats(5);
            _builder.SetEngine(new Engine(180));
            _builder.SetTransmission(Transmission.AUTOMATIC);
            _builder.SetAirbag(false);
        }

       
        public void ConstructTruck()
        {
            _builder.Reset();
            _builder.SetVehicleType(VehicleType.TRUCK);
            _builder.SetSeats(2);
            _builder.SetEngine(new Engine(400));
            _builder.SetTransmission(Transmission.MANUAL);
            _builder.SetAirbag(false);
        }


        public void ConstructSUV()
        {
            _builder.Reset();
            _builder.SetVehicleType(VehicleType.SUV);
            _builder.SetSeats(5);
            _builder.SetEngine(new Engine(2.6));
            _builder.SetTransmission(Transmission.AUTOMATIC_SEQUENTIAL);
            _builder.SetAirbag(true);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            IBuilder builder = new CarBuilder();
            Director director = new Director(builder);

            // Construção de um Sedan
            director.ConstructSedanCar();
            Vehicle sedan = builder.GetVehicle();
            Console.WriteLine("Sedan: " + sedan.ToString());

            // Construção de um Caminhão (Truck)
            director.ConstructTruck();
            Vehicle truck = builder.GetVehicle();
            Console.WriteLine("Truck: " + truck.ToString());

           
            director.ConstructSUV();
            Vehicle suv = builder.GetVehicle();
            Console.WriteLine("SUV: " + suv.ToString());

            Console.ReadLine();
        }
    }
}
