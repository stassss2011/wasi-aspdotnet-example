FROM scratch
COPY MyWebApp.wasm /
CMD ["/MyWebApp.wasm"]