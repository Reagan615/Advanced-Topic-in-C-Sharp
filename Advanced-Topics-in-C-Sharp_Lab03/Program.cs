using Advanced_Topics_in_C_Sharp_Lab03.Models;
using Route = Advanced_Topics_in_C_Sharp_Lab03.Models.Route;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

List<Route> routes = new List<Route>();

List<Stop> stops = new List<Stop>();

List<ScheduledStop> scheduledStops = new List<ScheduledStop>();

Route routeOne = new Route(1, "streetOne", Direction.North, true, false);
Route routeTwo = new Route(2, "streetTwo", Direction.East, true, true);
routes.Add(routeOne);
routes.Add(routeTwo);

Stop stopOne = new Stop(1, "streetOne", "firstStop", Direction.South);
Stop stopTwo = new Stop(2, "streetOne", "secondStop", Direction.West);
Stop stopThree = new Stop(3, "streetOne", "thirdStop", Direction.Southeast);
Stop stopFour = new Stop(4, "streetTwo", "forthStop", Direction.North);
Stop stopFive = new Stop(5, "streetTwo", "fifthStop", Direction.Southwest);

stops.Add(stopOne);
stops.Add(stopTwo);
stops.Add(stopThree);
stops.Add(stopFour);
stops.Add(stopFive);

ScheduledStop scheduledStopOne = new ScheduledStop(1, stopOne, routeOne, DateTime.Now);
ScheduledStop scheduledStopTwo = new ScheduledStop(2, stopTwo, routeOne, DateTime.Now.AddMinutes(10));
ScheduledStop scheduledStopThree = new ScheduledStop(3, stopThree, routeOne, DateTime.Now.AddMinutes(20));
ScheduledStop scheduledStopFour = new ScheduledStop(4, stopFour, routeOne, DateTime.Now.AddMinutes(30));
ScheduledStop scheduledStopFive = new ScheduledStop(5, stopFive, routeOne, DateTime.Now.AddMinutes(40));

ScheduledStop scheduledStopSix = new ScheduledStop(6, stopFive, routeTwo, DateTime.Now);
ScheduledStop scheduledStopSeven = new ScheduledStop(7, stopFour, routeTwo, DateTime.Now.AddMinutes(10));
ScheduledStop scheduledStopEight = new ScheduledStop(8, stopThree, routeTwo, DateTime.Now.AddMinutes(20));
ScheduledStop scheduledStopNine = new ScheduledStop(9, stopTwo, routeTwo, DateTime.Now.AddMinutes(30));
ScheduledStop scheduledStopTen = new ScheduledStop(10, stopOne, routeTwo, DateTime.Now.AddMinutes(40));

scheduledStops.Add(scheduledStopOne);
scheduledStops.Add(scheduledStopTwo);
scheduledStops.Add(scheduledStopThree);
scheduledStops.Add(scheduledStopFour);
scheduledStops.Add(scheduledStopFive);
scheduledStops.Add(scheduledStopSix);
scheduledStops.Add(scheduledStopSeven);
scheduledStops.Add(scheduledStopEight);
scheduledStops.Add(scheduledStopNine);
scheduledStops.Add(scheduledStopTen);


