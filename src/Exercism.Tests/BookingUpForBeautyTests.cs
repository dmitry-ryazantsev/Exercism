namespace BookingUpForBeauty;

[TestFixture]
public class AppointmentTests
{
    [Test]
    public void Schedule_ParseAppointmentDate()
    {
        Assert.That(Appointment.Schedule("July 25, 2019 13:45:00"), Is.EqualTo(new DateTime(2019, 07, 25, 13, 45, 0)));
    }

    [Test]
    public void HasPassed_AppointmentPassedDaysAgo()
    {
        Assert.That(Appointment.HasPassed(DateTime.Now.AddDays(-2)), Is.True);
    }

    [Test]
    public void HasPassed_AppointmentIsInTheFuture()
    {
        Assert.That(Appointment.HasPassed(DateTime.Now.AddMonths(1)), Is.False);
    }

    [Test]
    public void IsAfternoonAppointment_AppointmentInTheMorning()
    {
        Assert.That(Appointment.IsAfternoonAppointment(new DateTime(2019, 07, 25, 10, 45, 0)), Is.False);
    }

    [Test]
    public void IsAfternoonAppointment_AppointmentInTheAfternoon()
    {
        Assert.That(Appointment.IsAfternoonAppointment(new DateTime(2019, 07, 25, 17, 59, 0)), Is.True);
    }

    [Test]
    public void Description_AppointmentOnFridayAfternoon()
    {
        Assert.That(Appointment.Description(new DateTime(2019, 03, 29, 15, 0, 0)), Is.EqualTo("You have an appointment on 29.03.2019 15:00:00."));
    }
}