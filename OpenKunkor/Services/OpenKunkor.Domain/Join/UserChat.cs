﻿namespace OpenKunkor.Domain.Join;
public class UserChat
{
    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public int ChatId { get; set; }
    public Chat Chat { get; set; } = null!;
}
