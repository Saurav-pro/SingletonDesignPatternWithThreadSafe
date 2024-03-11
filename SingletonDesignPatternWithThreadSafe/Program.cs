using SingletonDesignPatternWithThreadSafe;

Thread thread1 = new Thread(() => 
{
    var Programinstance1 =    UploadService.Instance(1);

});
Thread thread2 = new Thread(() =>
{
    var Programinstance2 = UploadService.Instance(2);

});

thread1.Start();
thread2.Start();
thread1.Join(); 
thread2.Join();