using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MouseMover
{
    /// <summary>
    /// Background service for mouse moving
    /// </summary>
    public class MouseMoverService : BackgroundService
    {
        /// <summary>
        /// Move mouse every minute
        /// </summary>
        public int MoveTime { get; set; } = 60000;

        /// <summary>
        /// Random instance for generating mouse position
        /// </summary>
        public Random Rand { get; set; } = new Random();

        /// <summary>
        /// Min x or y value of point
        /// </summary>
        public int MinRange { get; set; } = 0;

        /// <summary>
        /// Max x or y value of point
        /// </summary>
        public int MaxRange { get; set; } = 1000;


        /// <summary>
        /// Execution logic for mouse moving action
        /// </summary>
        /// <param name="stoppingToken"></param>
        /// <returns></returns>
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                int x = Rand.Next(MinRange, MaxRange);
                int y = Rand.Next(MinRange, MaxRange);

                MouseHelper.SetCursorPos(x, y);

                Console.WriteLine($"Moved mouse cursor to postion ({x}, {y})");

                await Task.Delay(MoveTime);
            }
        }
    }
}
