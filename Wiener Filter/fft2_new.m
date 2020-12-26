function G=fft2_new(g)
M=size(g,1); %row
N=size(g,2); %column
G=[];
for x=0:M-1
    for u=0:N-1
        G(x+1,u+1)=exp(-j*2*pi*x*u/M);
    end
end
        