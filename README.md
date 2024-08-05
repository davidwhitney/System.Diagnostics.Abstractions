# System.Diagnostics.Abstractions

Hello, I see you find yourself here in 2024. That's amazing and you probably shouldn't be here anymore, but we all know what software development is like.

I find myself writing this readme because I just had to do necromancy on a pull request that I missed 2 years ago, about an copypasta mistake I made 8 years ago, in a library that I started 10 years ago. I'm not sure if I should be proud or ashamed of this.

"You probably shouldn't be injecting this" - but I too once did, so if you're stumbling into bugs, I'm sorry, and I've fixed them.

## What's in a name?

When I started this library I borrowed the naming from my other library System.Configuration.Abstractions - the name of which pre-dated .NET Core, and also the general trend of Microsoft publishing `System.Blah.Abstractions` packages. This is funny, because I now can't actually update this library to fix the bug in it, because that prefix is now sensibly and rightly a reserved name.

So:

- For versions before 1.0.9, you can use `System.Diagnostics.Abstractions` - but there's a bug in it, so you probably shouldn't.
- For versions after 1.1.0, you can use `UnofficialSystem.Diagnostics.Abstractions`

Sorry for the confusion, I will try not be good at naming ahead of time in the future ;)
