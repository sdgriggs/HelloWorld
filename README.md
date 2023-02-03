# HelloWorld
```mermaid
erDiagram       
          PCAP }|..|{ MUTINY PREP : input
          MUTINY PREP }|..|{ .fuzzer : yeilds
          .fuzzer }|..|{ MUTINY : input
          MUTINY }|..|{ IoT Device : attacks
          

```
