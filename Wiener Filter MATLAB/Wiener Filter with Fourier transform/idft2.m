function X = idft2(x)
        C = size(x,2); %number of columns
        R = size(x,1); %number of rows
        nR = 0:1:R-1; %row vector for n
        kR = 0:1:R-1; %row vector for k
        nkR=nR'*kR;
        nC = 0:1:C-1; %row vector for n
        kC = 0:1:C-1; %row vector for k
        nkC=nC'*kC;
        y = zeros(size(x));
        y1 = y;
        for c = 1:C
            y(:,c) = idft_row(x(:,c),R,nkR);
        end
        for r = 1:R
            y1(r,:) =idft_col(y(r,:).',C,nkC);
        end
        X = y1;
end

function [Xk] = idft_col(xn,N,nk) 
       WN = exp(i*2*pi/N); %Twiddle factor (w)
       WNnk = WN .^ nk; %DFT matrix
       Xk = (1/N)*WNnk*xn; 
end  
 function [Xk] = idft_row(xn,N,nk) 
       WN = exp(i*2*pi/N); %Twiddle factor (w)
       WNnk = WN .^ nk; %DFT matrix
       Xk = (1/N)*WNnk*xn; 
 end  
