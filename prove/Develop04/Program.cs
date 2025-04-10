
class Program
{
    static void Main(string[] args)
    {
       Animation animation = new Animation();
       Breath breathingActivity = new Breath();
       Listing listingActivity = new Listing();
       Reflect reflectionActivity = new Reflect();
       Goal goalActivity = new Goal(); 

       int ans = 0; 
       while (ans != 5)
       {
        animation.DisplayMenu();
        ans = int.Parse(Console.ReadLine());

        if (ans == 1)
        {
            breathingActivity.WelcomeDisplay();
            breathingActivity.SetDuration();
            animation.GetReadyAnimation();
            breathingActivity.BreathingExercise();
            breathingActivity.FinishDisplay();
            
        } else if(ans == 2)
        {
            listingActivity.WelcomeDisplay();
            listingActivity.SetDuration();
            animation.GetReadyAnimation();
            listingActivity.ListingExercise();
            listingActivity.FinishDisplay();
        } else if(ans == 3)
        {
            reflectionActivity.WelcomeDisplay();
            reflectionActivity.SetDuration();
            animation.GetReadyAnimation();
            reflectionActivity.ReflectionExercise();
            reflectionActivity.FinishDisplay();
        } else if(ans == 4)
        {
            goalActivity.WelcomeDisplay();
            goalActivity.SetDuration();
            animation.GetReadyAnimation();
            goalActivity.GoalExercise();
            goalActivity.FinishDisplay();
        } else if(ans == 5)
        {
            Console.Write("\nGood Bye~~");
        } else {
            Console.Write("\nSorry that is not a valid answer Please try again");
            Thread.Sleep(3000);
            Console.Clear();
        }

       }
    }
}