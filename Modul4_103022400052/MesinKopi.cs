using System;

public class MesinKopi
{
	public enum State { OFF, STANBY, BREWING, MAINTENANCE}
	public enum Trigger { POWER_ON, POWER_OFF, START_BREW, FINISH_BREW, START_MAINTENANCE, FINISH_MAINTENANCE}
	
	public State currentState = State.OFF;

	public void TriggerState(Trigger trigger)
	{
		State nextState = currentState;

		switch (currentState) { 
			case State.OFF:
				if (trigger == Trigger.POWER_ON) nextState = State.STANBY;
				break;

			case State.STANBY:
				if (trigger == Trigger.START_BREW) nextState = State.BREWING;
				else if (trigger == Trigger.START_MAINTENANCE) nextState = State.MAINTENANCE;
				else if (trigger == Trigger.POWER_OFF) nextState = State.OFF;
				break;

			case State.BREWING:
				if (trigger == Trigger.FINISH_BREW) nextState = State.STANBY;
				break;

			case State.MAINTENANCE:
				if (trigger == Trigger.FINISH_MAINTENANCE) nextState = State.STANBY; 
				break;

				if (nextState != currentState)
				{
					PrintPesan(currentState, nextState);
					currentState = nextState;
				}
				else {
					Console.WriteLine("Perubahan state tidak valid");
				}
		}
	}

	public void PrintPesan(State prev, State next) {
		if (prev == State.OFF && next == State.STANBY)
			Console.WriteLine("Mesin Off berubah menjadi Standby");
		else if (prev == State.STANBY && next == State.BREWING)
			Console.WriteLine("Mesin Standby berubah menjadi Brewing");
		else if (prev == State.BREWING && next == State.STANBY)
			Console.WriteLine("Mesin Brewing berubah menjadi Standby");
		else if (prev == State.STANBY && next == State.MAINTENANCE)
			Console.WriteLine("Mesin Standby berubah menjadi Maintenance");
		else if (prev == State.MAINTENANCE && next == State.STANBY)
			Console.WriteLine("Mesin Maintenance berubah menjadi Standby");
		else if (prev == State.STANBY && next == State.OFF)
			Console.WriteLine("Mesin Standby berubah menjadi Off");
	}
}
