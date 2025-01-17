﻿#if NETFRAMEWORK
using System;
using System.Security;
#endif

namespace Xunit;

#if NETFRAMEWORK
/// <summary>
/// Base class for all long-lived objects that may cross over an AppDomain.
/// </summary>
public abstract class LongLivedMarshalByRefObject : MarshalByRefObject
{
	/// <inheritdoc/>
	[SecurityCritical]
	public override sealed object InitializeLifetimeService()
	{
		return null!;  // MarshalByRefObject does not seem to be properly annotated for nullability
	}
}
#else
/// <summary>
/// Base class for all long-lived objects that may cross over an AppDomain.
/// </summary>
public abstract class LongLivedMarshalByRefObject
{ }
#endif
