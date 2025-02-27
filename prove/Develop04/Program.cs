/*
Breathing Activity - Help the user pace their breathing to have a session of deep breathing for a certain amount of time. They might find more peace and less stress through the exercise.
Reflection Activity - This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.
Listing Activity - Guide the user to think broadly, by helping them list as many things as they can in a certain area of strength or positivity. They might discover more breadth than they previously realized.
*/


class Program
{
    static void Main(string[] args)
    {
       Animation animation = new Animation();
       Breath breathingActivity = new Breath();
       Listing listingActivity = new Listing();
       Reflect reflectionActivity = new Reflect(); 

       int ans = 0; 
       while (ans != 4)
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
            Console.Write("\nGood Bye~~");
            break;
        } else {
            Console.Write("\nSorry that is not a valid answer Please try again");
            Thread.Sleep(3000);
            Console.Clear();
        }

       }
    }
}