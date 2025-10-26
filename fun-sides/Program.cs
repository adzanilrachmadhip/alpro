using System;
using System.Threading;

namespace PengulanganLucu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            
            while (running)
            {
                Console.Clear();
                ShowMenu();
                
                Console.Write("\nPilih animasi (1-12): ");
                string pilihan = Console.ReadLine();
                
                Console.Clear();
                
                switch (pilihan)
                {
                    case "1":
                        LoadingBar();
                        break;
                    case "2":
                        HeartBeat();
                        break;
                    case "3":
                        RainbowText();
                        break;
                    case "4":
                        TypingEffect();
                        break;
                    case "5":
                        SpinningLoader();
                        break;
                    case "6":
                        MatrixRain();
                        break;
                    case "7":
                        BouncingBall();
                        break;
                    case "8":
                        ChristmasTree();
                        break;
                    case "9":
                        ProgressDownload();
                        break;
                    case "10":
                        CountdownRocket();
                        break;
                    case "11":
                        DancingText();
                        break;
                    case "12":
                        SnakeAnimation();
                        break;
                    case "0":
                        Console.WriteLine("\n👋 Dadah! Sampai jumpa!");
                        running = false;
                        continue;
                    default:
                        Console.WriteLine("❌ Pilihan tidak valid!");
                        Thread.Sleep(1000);
                        continue;
                }
                
                Console.WriteLine("\n\nTekan Enter untuk kembali ke menu...");
                Console.ReadLine();
            }
        }
        
        static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║    🎨 PENGULANGAN LUCU & KREATIF 🎨       ║");
            Console.WriteLine("║         by Adzanil & Aurora AI             ║");
            Console.WriteLine("╠════════════════════════════════════════════╣");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║  1. ⏳ Loading Bar Animation               ║");
            Console.WriteLine("║  2. 💓 Heart Beat Animation                ║");
            Console.WriteLine("║  3. 🌈 Rainbow Text                        ║");
            Console.WriteLine("║  4. ⌨️  Typing Effect                      ║");
            Console.WriteLine("║  5. ⭕ Spinning Loader                     ║");
            Console.WriteLine("║  6. 💚 Matrix Rain Effect                  ║");
            Console.WriteLine("║  7. ⚽ Bouncing Ball                       ║");
            Console.WriteLine("║  8. 🎄 Christmas Tree Builder              ║");
            Console.WriteLine("║  9. 📥 Download Progress                   ║");
            Console.WriteLine("║ 10. 🚀 Rocket Countdown                    ║");
            Console.WriteLine("║ 11. 💃 Dancing Text                        ║");
            Console.WriteLine("║ 12. 🐍 Snake Animation                     ║");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("║  0. 🚪 Exit                                ║");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.ResetColor();
        }
        
        // ========================================
        // 1. LOADING BAR ANIMATION
        // ========================================
        static void LoadingBar()
        {
            Console.WriteLine("⏳ LOADING BAR ANIMATION\n");
            
            int totalWidth = 50;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Loading: [");
            
            for (int i = 0; i <= totalWidth; i++)
            {
                // Hitung persentase
                int percent = (i * 100) / totalWidth;
                
                // Tampilkan bar
                Console.SetCursorPosition(10, Console.CursorTop);
                Console.Write("[");
                
                for (int j = 0; j < totalWidth; j++)
                {
                    if (j < i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("█");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("░");
                    }
                }
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"] {percent}%");
                
                Thread.Sleep(50);
            }
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n✅ Loading Complete! 🎉");
            Console.ResetColor();
        }
        
        // ========================================
        // 2. HEART BEAT ANIMATION
        // ========================================
        static void HeartBeat()
        {
            Console.WriteLine("💓 HEART BEAT ANIMATION\n");
            
            string[] hearts = { "💙", "💚", "💛", "🧡", "❤️", "💜", "🤍", "🖤" };
            
            for (int beat = 0; beat < 20; beat++)
            {
                // Beat besar
                Console.SetCursorPosition(35, 10);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(hearts[beat % hearts.Length] + " ❤️ " + hearts[(beat + 1) % hearts.Length]);
                Thread.Sleep(100);
                
                // Beat kecil
                Console.SetCursorPosition(35, 10);
                Console.Write("  ♥  ");
                Thread.Sleep(100);
            }
            
            Console.SetCursorPosition(0, 15);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("💖 Heart is beating! 💖");
            Console.ResetColor();
        }
        
        // ========================================
        // 3. RAINBOW TEXT
        // ========================================
        static void RainbowText()
        {
            Console.WriteLine("🌈 RAINBOW TEXT ANIMATION\n");
            
            string text = "HELLO ADZANIL! WELCOME TO C# PROGRAMMING! 🎉";
            ConsoleColor[] colors = 
            {
                ConsoleColor.Red, ConsoleColor.DarkYellow, ConsoleColor.Yellow,
                ConsoleColor.Green, ConsoleColor.Cyan, ConsoleColor.Blue,
                ConsoleColor.Magenta
            };
            
            for (int loop = 0; loop < 10; loop++)
            {
                Console.SetCursorPosition(15, 8);
                
                for (int i = 0; i < text.Length; i++)
                {
                    Console.ForegroundColor = colors[(i + loop) % colors.Length];
                    Console.Write(text[i]);
                }
                
                Thread.Sleep(200);
            }
            
            Console.SetCursorPosition(0, 12);
            Console.ResetColor();
        }
        
        // ========================================
        // 4. TYPING EFFECT
        // ========================================
        static void TypingEffect()
        {
            Console.WriteLine("⌨️  TYPING EFFECT\n");
            
            string message = "Halo Adzanil! Ini adalah typing effect yang keren. " +
                           "Seolah-olah ada yang mengetik secara real-time. " +
                           "Seru kan? 😊";
            
            Console.ForegroundColor = ConsoleColor.Green;
            
            foreach (char c in message)
            {
                Console.Write(c);
                
                // Random delay untuk efek lebih natural
                if (c == '.' || c == '!' || c == '?')
                    Thread.Sleep(500);
                else if (c == ' ')
                    Thread.Sleep(50);
                else
                    Thread.Sleep(30);
            }
            
            // Blinking cursor effect
            for (int i = 0; i < 5; i++)
            {
                Console.Write("_");
                Thread.Sleep(300);
                Console.Write("\b \b");
                Thread.Sleep(300);
            }
            
            Console.WriteLine();
            Console.ResetColor();
        }
        
        // ========================================
        // 5. SPINNING LOADER
        // ========================================
        static void SpinningLoader()
        {
            Console.WriteLine("⭕ SPINNING LOADER\n");
            
            char[] spinner = { '|', '/', '-', '\\' };
            string[] messages = 
            {
                "Loading data...",
                "Processing files...",
                "Connecting to server...",
                "Almost done...",
                "Finalizing..."
            };
            
            foreach (string msg in messages)
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.SetCursorPosition(30, 10);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"{spinner[i % 4]} {msg} {spinner[i % 4]}");
                    Thread.Sleep(100);
                }
            }
            
            Console.SetCursorPosition(30, 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("✅ Done! All tasks completed! ");
            Console.ResetColor();
        }
        
        // ========================================
        // 6. MATRIX RAIN EFFECT
        // ========================================
        static void MatrixRain()
        {
            Console.WriteLine("💚 MATRIX RAIN EFFECT (5 detik)\n");
            Console.CursorVisible = false;
            
            Random random = new Random();
            int width = Console.WindowWidth;
            int height = Console.WindowHeight - 5;
            
            // Matrix characters
            string chars = "01アイウエオカキクケコサシスセソ";
            
            for (int frame = 0; frame < 50; frame++)
            {
                for (int col = 0; col < width; col += 2)
                {
                    if (random.Next(0, 10) > 7)
                    {
                        int row = random.Next(3, height);
                        Console.SetCursorPosition(col, row);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(chars[random.Next(chars.Length)]);
                        
                        if (random.Next(0, 10) > 8)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(chars[random.Next(chars.Length)]);
                        }
                    }
                }
                Thread.Sleep(100);
            }
            
            Console.SetCursorPosition(0, height + 2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Wake up, Neo... 💊");
            Console.ResetColor();
            Console.CursorVisible = true;
        }
        
        // ========================================
        // 7. BOUNCING BALL
        // ========================================
        static void BouncingBall()
        {
            Console.WriteLine("⚽ BOUNCING BALL\n");
            Console.CursorVisible = false;
            
            int x = 5, y = 5;
            int dx = 1, dy = 1;
            int width = 60;
            int height = 15;
            
            for (int frame = 0; frame < 100; frame++)
            {
                // Clear previous position
                Console.SetCursorPosition(x, y + 3);
                Console.Write(" ");
                
                // Update position
                x += dx;
                y += dy;
                
                // Bounce on edges
                if (x >= width || x <= 0) dx = -dx;
                if (y >= height || y <= 0) dy = -dy;
                
                // Draw ball
                Console.SetCursorPosition(x, y + 3);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("●");
                
                Thread.Sleep(50);
            }
            
            Console.SetCursorPosition(0, height + 5);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("⚽ Ball stopped! Great game!");
            Console.ResetColor();
            Console.CursorVisible = true;
        }
        
        // ========================================
        // 8. CHRISTMAS TREE BUILDER
        // ========================================
        static void ChristmasTree()
        {
            Console.WriteLine("🎄 BUILDING CHRISTMAS TREE...\n");
            
            int height = 10;
            Random random = new Random();
            
            // Star
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < height; i++)
                Console.Write(" ");
            Console.WriteLine("⭐");
            Thread.Sleep(300);
            
            // Tree
            for (int i = 1; i <= height; i++)
            {
                // Spaces
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }
                
                // Tree part
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    // Random decorations
                    int decoration = random.Next(0, 15);
                    
                    if (decoration == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("●");
                    }
                    else if (decoration == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("◆");
                    }
                    else if (decoration == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("★");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");
                    }
                }
                
                Console.WriteLine();
                Thread.Sleep(200);
            }
            
            // Trunk
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < height - 2; j++)
                    Console.Write(" ");
                Console.WriteLine("|||");
                Thread.Sleep(100);
            }
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n🎁 Merry Christmas! 🎅");
            Console.ResetColor();
        }
        
        // ========================================
        // 9. DOWNLOAD PROGRESS
        // ========================================
        static void ProgressDownload()
        {
            Console.WriteLine("📥 DOWNLOADING FILE...\n");
            
            Random random = new Random();
            double totalSize = 100.0; // MB
            double downloaded = 0.0;
            
            while (downloaded < totalSize)
            {
                // Random download speed
                double speed = random.Next(5, 15);
                downloaded += speed;
                
                if (downloaded > totalSize)
                    downloaded = totalSize;
                
                double percentage = (downloaded / totalSize) * 100;
                
                Console.SetCursorPosition(0, 5);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Downloaded: {downloaded:F1} / {totalSize:F1} MB");
                Console.WriteLine($"Progress: {percentage:F1}%");
                Console.WriteLine($"Speed: {speed:F1} MB/s");
                
                // Progress bar
                int barWidth = 40;
                int filled = (int)((downloaded / totalSize) * barWidth);
                
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < filled; i++)
                    Console.Write("█");
                
                Console.ForegroundColor = ConsoleColor.DarkGray;
                for (int i = filled; i < barWidth; i++)
                    Console.Write("░");
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("]");
                
                Thread.Sleep(300);
            }
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n✅ Download Complete! 🎉");
            Console.ResetColor();
        }
        
        // ========================================
        // 10. ROCKET COUNTDOWN
        // ========================================
        static void CountdownRocket()
        {
            Console.WriteLine("🚀 ROCKET LAUNCH COUNTDOWN\n");
            
            string[] rocket = 
            {
                "     /\\",
                "    /  \\",
                "   |    |",
                "   |NASA|",
                "   |    |",
                "  /|    |\\",
                " / |    | \\",
                "/__|____|__\\"
            };
            
            // Countdown
            for (int i = 10; i >= 1; i--)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n\n\n        T-{i} seconds...\n");
                
                Console.ForegroundColor = ConsoleColor.White;
                foreach (string line in rocket)
                {
                    Console.WriteLine("        " + line);
                }
                
                Thread.Sleep(1000);
            }
            
            // Launch!
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n        🔥 IGNITION! 🔥\n");
            Thread.Sleep(500);
            
            // Rocket going up
            for (int altitude = 0; altitude < 15; altitude++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                
                // Move rocket up
                for (int i = 0; i < altitude; i++)
                {
                    Console.WriteLine();
                }
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                foreach (string line in rocket)
                {
                    Console.WriteLine("        " + line);
                }
                
                // Flames
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("       ^^  ^^");
                Console.WriteLine("      ^^  ^^  ^^");
                
                Thread.Sleep(100);
            }
            
            Console.SetCursorPosition(0, 20);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n🌟 Launch Successful! Rocket reached orbit! 🛰️");
            Console.ResetColor();
        }
        
        // ========================================
        // 11. DANCING TEXT
        // ========================================
        static void DancingText()
        {
            Console.WriteLine("💃 DANCING TEXT\n");
            Console.CursorVisible = false;
            
            string text = "♪ CODING IS FUN! ♪";
            
            for (int wave = 0; wave < 30; wave++)
            {
                Console.SetCursorPosition(20, 8);
                
                for (int i = 0; i < text.Length; i++)
                {
                    int offset = (int)(Math.Sin((wave + i) * 0.5) * 2);
                    
                    Console.SetCursorPosition(20 + i * 2, 8 + offset);
                    
                    // Rainbow colors
                    ConsoleColor[] colors = 
                    {
                        ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green,
                        ConsoleColor.Cyan, ConsoleColor.Blue, ConsoleColor.Magenta
                    };
                    
                    Console.ForegroundColor = colors[(i + wave) % colors.Length];
                    Console.Write(text[i]);
                }
                
                Thread.Sleep(100);
                
                // Clear for next frame
                for (int y = 5; y < 12; y++)
                {
                    Console.SetCursorPosition(20, y);
                    Console.Write(new string(' ', 40));
                }
            }
            
            Console.SetCursorPosition(0, 15);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("🎵 Keep dancing with code! 🎶");
            Console.ResetColor();
            Console.CursorVisible = true;
        }
        
        // ========================================
        // 12. SNAKE ANIMATION
        // ========================================
        static void SnakeAnimation()
        {
            Console.WriteLine("🐍 SNAKE MOVING...\n");
            Console.CursorVisible = false;
            
            string snake = "~oOo~";
            int y = 10;
            
            // Move right
            for (int x = 0; x < 60; x++)
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(snake);
                Thread.Sleep(50);
                
                Console.SetCursorPosition(x, y);
                Console.Write(new string(' ', snake.Length));
            }
            
            // Move down
            for (int yMove = y; yMove < y + 5; yMove++)
            {
                Console.SetCursorPosition(60, yMove);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(snake);
                Thread.Sleep(100);
                
                Console.SetCursorPosition(60, yMove);
                Console.Write(new string(' ', snake.Length));
            }
            
            // Move left
            for (int x = 60; x >= 0; x--)
            {
                Console.SetCursorPosition(x, y + 5);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(snake);
                Thread.Sleep(50);
                
                Console.SetCursorPosition(x, y + 5);
                Console.Write(new string(' ', snake.Length));
            }
            
            Console.SetCursorPosition(0, y + 8);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("🐍 Sssssss... Snake finished moving!");
            Console.ResetColor();
            Console.CursorVisible = true;
        }
    }
}